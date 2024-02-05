using Flurl.Http;

namespace Kitten.Sdk.Client;

public class KittenClient
{
    internal readonly IFlurlClient KittenHttpClient;
    
    /// <summary>
    /// 用指定的配置项初始化 <see cref="KittenClient"/> 类的新实例。
    /// </summary>
    /// <param name="options">配置项 <see cref="KittenClientOptions"/></param>
    public KittenClient(KittenClientOptions options)
    {
        //参数为空抛出异常
        ArgumentNullException.ThrowIfNull(options);
        //新建客户端
        KittenHttpClient = new FlurlClient(options.KittenClientHttpEndpoints)
            .WithTimeout(options.Timeout);
        //如果有密钥进行拼接
        if (!string.IsNullOrWhiteSpace(options.Secret))
        {
            KittenHttpClient.WithOAuthBearerToken(options.Secret);
        }
    }

    /// <summary>
    /// 重置客户端请求的基础域名
    /// </summary>
    /// <param name="options">配置项 <see cref="KittenClientOptions"/></param>
    /// <returns></returns>
    public bool ResetKittenHttpClientBaseUrl(KittenClientOptions options)
    {
        try
        {
            KittenHttpClient.BaseUrl = options.KittenClientHttpEndpoints;
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}