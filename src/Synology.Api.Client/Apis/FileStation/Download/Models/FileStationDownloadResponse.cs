using System.IO;

namespace Synology.Api.Client.Apis.FileStation.Download.Models;

public class FileStationDownloadResponse : IDownloadableResponse
{
    public int Error { get; set; }
    public byte[] FileBytes { get; set; }
}