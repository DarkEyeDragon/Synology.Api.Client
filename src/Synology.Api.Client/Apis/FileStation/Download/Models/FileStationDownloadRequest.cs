namespace Synology.Api.Client.Apis.FileStation.Download.Models
{
    public class FileStationDownloadRequest
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri">Optional. Accepts HTTP/FTP/magnet/ED2K links or the file
        /// path starting with a shared folder, separated by ","</param>
        /// <param name="mode">
        /// Mode used to download files/folders, value could be:
        /// "open": try to trigger the application, such as a web browser, to open it. Content-Type of the HTTP header of the response is set to MIME type according to file extension.
        /// "download": try to trigger the application, such as a web browser, to download it. ContentType of the HTTP header of response is set to application/octet-stream and ContentDisposition of the HTTP header of the response is set to attachment.</param>
        public FileStationDownloadRequest(string uri, DownloadMode mode = DownloadMode.DOWNLOAD)
        {
            Uri = uri;
            Mode = mode;
        }


        /// <summary>
        /// Optional. Accepts HTTP/FTP/magnet/ED2K links or the file
        /// path starting with a shared folder, separated by ","
        /// </summary>
        /// <returns></returns>
        public string Uri { get; }

        public DownloadMode Mode { get; set; }


        public enum DownloadMode
        {
            OPEN,
            DOWNLOAD
        }
    }
}