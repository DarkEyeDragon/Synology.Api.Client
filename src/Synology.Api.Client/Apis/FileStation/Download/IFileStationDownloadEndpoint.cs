using System.Threading.Tasks;
using Synology.Api.Client.Apis.DownloadStation.Task.Models;
using Synology.Api.Client.Apis.FileStation.Download.Models;

namespace Synology.Api.Client.Apis.FileStation.Download;

public interface IFileStationDownloadEndpoint
{
    public Task<FileStationDownloadResponse> DownloadAsync(
        FileStationDownloadRequest fileStationDownloadRequest);
}