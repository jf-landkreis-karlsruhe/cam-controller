﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace CamFtpUpload
{
    class FTPClient
    {
    
    #region Properties

    public string Adress { get; set; }
    public string User { get; set; }
    public string Password { get; set; }

    #endregion

    #region Constructor

    /// <summary>
    /// Initialisiert eine neue Instanz der FTP Helper Klasse
    /// </summary>
    /// <param name="adress">Name oder IP Adresse des Servers</param>
    /// <param name="user">Benutzername</param>
    /// <param name="password">Passwort</param>
    public FTPClient(string adress, string user, string password)
    {
        this.Adress = adress;
        this.User = user;
        this.Password = password;
    }

    #endregion

    #region Events

    public delegate void ReceivedFileListCompleteEventhandler();
    public event ReceivedFileListCompleteEventhandler ReceivedFileListComplete;

    #endregion

    /// <summary>
    /// Überprüft ob eine Verbindung zum FTP Server besteht
    /// </summary>
    public void CheckConnection()
    {
        try
        {
            FtpWebRequest.DefaultWebProxy = null;
            FtpWebRequest ftpWebRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + this.Adress + "/"));
            ftpWebRequest.Credentials = new NetworkCredential(this.User, this.Password);

            //Als Methode muss ListDirectory gewählt werden!
            ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectory;

            WebResponse webResponse = ftpWebRequest.GetResponse();
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Lädt Dateien auf einen FTP Server
    /// </summary>
    /// <param name="remoteFolder">Zielverzeichnis</param>
    /// <param name="fileInfo"></param>
    public void UploadFile(string remoteFolder, string remoteFileName, FileInfo fileInfo)
    {
        try
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri("ftp://" + Adress + "/" + remoteFolder + "/" + remoteFileName));

            request.Method = WebRequestMethods.Ftp.UploadFile;

            request.Credentials = new NetworkCredential(User, Password);

            Stream ftpStream = request.GetRequestStream();

            FileStream file = File.OpenRead(fileInfo.FullName);

            int length = 1024;
            byte[] buffer = new byte[length];
            int bytesRead = 0;

            do
            {
                bytesRead = file.Read(buffer, 0, length);
                ftpStream.Write(buffer, 0, bytesRead);
            }
            while (bytesRead != 0);

            file.Close();
            ftpStream.Close();
        }
        catch (WebException)
        {
            throw;
        }
    }

    /// <summary>
    /// Lädt Dateien auf einen FTP Server
    /// </summary>
    /// <param name="fileInfo"></param>
    public void UploadFile(FileInfo fileInfo)
    {
        this.UploadFile("", fileInfo.Name, fileInfo);
    }


    /// <summary>
    /// Liefert eine Liste von Dateien zurück, die sich in einem bestimmten Verzeichnis auf dem Server befinden
    /// </summary>
    /// <returns></returns>
    public List<string> GetFileList(string remoteFolder)
    {
        FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://" + Adress + "/" + remoteFolder);
        ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectory;

        WebResponse webResponse = null;

        ftpWebRequest.Credentials = new NetworkCredential(User, Password);

        try
        {
            webResponse = ftpWebRequest.GetResponse();
        }
        catch (Exception)
        {
            throw;
        }

        List<string> files = new List<string>();

        StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());

        while (!streamReader.EndOfStream)
        {
            files.Add(streamReader.ReadLine());
        }

        streamReader.Close();

        webResponse.Close();

        return files;
    }

    /// <summary>
    /// Liefert eine Liste von Dateien zurück
    /// </summary>
    /// <returns></returns>
    public List<string> GetFileList()
    {
        return this.GetFileList("");
    }

    /// <summary>
    /// Lädt eine Datei vom FTP Server herunter
    /// </summary>
    public void DownloadFile(string remoteFolder, FileInfo file, string destinationFolder, FileInfo destinationFile)
    {
        try
        {
            WebClient webClient = new WebClient();

            webClient.Credentials = new NetworkCredential(User, Password);

            byte[] data = webClient.DownloadData(new Uri("ftp://" + Adress + "/" + remoteFolder + "/" + file.Name));

            FileStream fileStream = File.Create(destinationFolder + @"\" + destinationFile);

            fileStream.Write(data, 0, data.Length);

            fileStream.Close();
        }
        catch (WebException)
        {
            throw;
        }
    }

    /// <summary>
    /// Lädt eine Datei vom FTP Server herunter
    /// </summary>
    /// <param name="file"></param>
    /// <param name="destinationFolder"></param>
    /// <param name="destinationFile"></param>
    public void DownloadFile(FileInfo file, string destinationFolder, FileInfo destinationFile)
    {
        this.DownloadFile("", file, destinationFolder, destinationFile);
    }

    /// <summary>
    /// Löscht eine Datei vom FTP Server
    /// </summary>
    /// <param name="remoteFolder">Zielverzeichnis</param>
    /// <param name="fileInfo">Datei</param>
    public void DeleteFile(string remoteFolder, FileInfo fileInfo)
    {
        try
        {
            FtpWebRequest ftpWebRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + Adress + "/" + remoteFolder + "/" + fileInfo.Name));
            ftpWebRequest.UseBinary = true;
            ftpWebRequest.Credentials = new NetworkCredential(User, Password);
            ftpWebRequest.Method = WebRequestMethods.Ftp.DeleteFile;
            ftpWebRequest.Proxy = null;
            ftpWebRequest.KeepAlive = false;
            ftpWebRequest.UsePassive = false;
            ftpWebRequest.GetResponse();
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Löscht eine Datei vom FTP Server
    /// </summary>
    /// <param name="fileInfo">Datei</param>
    public void DeleteFile(FileInfo fileInfo)
    {
        DeleteFile("", fileInfo);
    }

    /// <summary>
    /// Erstellt einen Order auf dem FTP Server in einem beliebigen Unterverzeichnis
    /// </summary>
    /// <param name="remoteFolder">Zielverzeichnis</param>
    /// <param name="folder">Verzeichnisname</param>
    public void CreateFolder(string remoteFolder, string folder)
    {
        try
        {
            FtpWebRequest ftpWebRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + Adress + "/" + remoteFolder + "/" + folder));
            ftpWebRequest.UseBinary = true;
            ftpWebRequest.Credentials = new NetworkCredential(User, Password);
            ftpWebRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
            ftpWebRequest.Proxy = null;
            ftpWebRequest.KeepAlive = false;
            ftpWebRequest.UsePassive = false;
            ftpWebRequest.GetResponse();
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Erstellt einen Ordner im Root Verzeichnis des FTP Nutzers
    /// </summary>
    /// <param name="folder">Verzeichnisname</param>
    public void CreateFolder(string folder)
    {
        this.CreateFolder("", folder);
    }

    }
}
