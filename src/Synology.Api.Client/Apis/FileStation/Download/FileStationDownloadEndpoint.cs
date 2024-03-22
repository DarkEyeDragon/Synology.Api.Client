using System.Collections.Generic;
using System.IO.Abstractions;
using System.Threading.Tasks;
using Synology.Api.Client.ApiDescription;
using Synology.Api.Client.Apis.DownloadStation.Task.Models;
using Synology.Api.Client.Apis.FileStation.Download.Models;
using Synology.Api.Client.Session;

namespace Synology.Api.Client.Apis.FileStation.Download;

public class FileStationDownloadEndpoint: IFileStationDownloadEndpoint
{
    private readonly ISynologyHttpClient _synologyHttpClient;
    private readonly IApiInfo _apiInfo;
    private readonly ISynologySession _session;
    private readonly IFileSystem _fileSystem;

    public FileStationDownloadEndpoint(ISynologyHttpClient synologyHttpClient, IApiInfo apiInfo, ISynologySession session)
        : this(synologyHttpClient, apiInfo, session, new FileSystem())
    {
    }

    public FileStationDownloadEndpoint(ISynologyHttpClient synologyHttpClient,
        IApiInfo apiInfo,
        ISynologySession session,
        IFileSystem fileSystem)
    {
        _synologyHttpClient = synologyHttpClient;
        _apiInfo = apiInfo;
        _session = session;
        _fileSystem = fileSystem;
    }
    
    public Task<FileStationDownloadResponse> DownloadAsync(
        FileStationDownloadRequest fileStationDownloadRequest)
    {
        var queryParams = new Dictionary<string, string?>
        {
            { "path", fileStationDownloadRequest.Uri }
        };
        return _synologyHttpClient.GetAsync<FileStationDownloadResponse>(_apiInfo, "download", queryParams,
            _session);
    }
}