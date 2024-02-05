using Flurl.Http;
using Kitten.Sdk.Client;
using Kitten.Sdk.Models;

namespace Kitten.Sdk.Extensions;

public static class KittenClientExecuteConfigsExtensions
{
    /// <summary>
    /// 获取服务端启动状态
    /// </summary>
    /// <param name="client"><see cref="KittenClient"/></param>
    /// <returns></returns>
    public static async Task<bool> ExecuteGetStatus(this KittenClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        try
        {
            _ = await client.KittenHttpClient
                .Request()
                .GetJsonAsync<ExecuteGetStatusResponse>();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    /// <summary>
    /// 获取服务端版本号信息
    /// </summary>
    /// <param name="client"><see cref="KittenClient"/></param>
    /// <returns></returns>
    public static async Task<ExecuteGetVersionResponse> ExecuteGetVersion(this KittenClient client)
    {
        ArgumentNullException.ThrowIfNull(client);
        return await client.KittenHttpClient
            .Request(KittenClientEndpoints.EndPoints.Version)
            .GetJsonAsync<ExecuteGetVersionResponse>();
    }
    
    /// <summary>
    /// 获取服务端版本号信息
    /// </summary>
    /// <param name="client"><see cref="KittenClient"/></param>
    /// <param name="cancellationToken">监控取消请求的令牌</param>
    /// <returns></returns>
    public static async Task<ExecuteGetVersionResponse> ExecuteGetVersion(this KittenClient client, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(client);
        return await client.KittenHttpClient
            .Request(KittenClientEndpoints.EndPoints.Version)
            .GetJsonAsync<ExecuteGetVersionResponse>(cancellationToken: cancellationToken);
    }
}