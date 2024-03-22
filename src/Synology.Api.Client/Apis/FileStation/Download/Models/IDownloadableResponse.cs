using System.IO;

namespace Synology.Api.Client.Apis.FileStation.Download.Models;

public interface IDownloadableResponse
{
    public byte[] FileBytes { get; set; }
    public int Error { get; set; }
}