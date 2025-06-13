### Cam Controller
This repository contains two projects:
* **WebCamImageDownloader**: A C# program that downloads images from a webcam URL.
* **CamFtpUploader**: A C# program that uploads images to an FTP server.

### WebCamImageDownloader
This program downloads images from a webcam URL and stores them in a folder.

#### Download Urls
##### Hohe Auflösung:
http://[IP-Adresse]/web/cgi-bin/hi3510/snap.cgi?&-getstream&-snapone&-chn=3

Beispiel: http://192.168.1.71/web/cgi-bin/hi3510/snap.cgi?&-getstream&-snapone&-chn=3



##### Niedrige Auflösung:
http://[IP-Adresse]/web/cgi-bin/hi3510/snap.cgi?&-getstream&-snapone&-chn=2

Beispiel: http://192.168.1.71/web/cgi-bin/hi3510/snap.cgi?&-getstream&-snapone&-chn=2

### CamFtpUploader
This program uploads images to an FTP server.

#### Resize Image on Upload

If the textbox `Image Upload width:` is >0, a copy of the image is created which is resized to the configured width.
The copy is created in the subfolder `resize` and is used for the upload process.