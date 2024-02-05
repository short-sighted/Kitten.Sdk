namespace Kitten.Sdk.Client;

/// <summary>
/// 用于构造<see cref="KittenClient"/>时使用的配置项
/// </summary>
public class KittenClientOptions
{
    /// <summary>
    /// 获取或设置请求超时时间(单位：毫秒)
    /// <para>默认值：30000</para>
    /// </summary>
    public int Timeout { get; set; } = 30 * 1000;

    /// <summary>
    /// 获取或设置Kitten请求时的密钥
    /// </summary>
    public string? Secret { get; set; } = default;

    /// <summary>
    /// Http请求地址
    /// <para>默认值：<see cref="KittenClientEndpoints.BaseUrl.HttpDefault"/></para>
    /// </summary>
    public string KittenClientHttpEndpoints { get; init; } = KittenClientEndpoints.BaseUrl.HttpDefault;

    /// <summary>
    /// WebSocket请求地址
    /// <para>默认值：<see cref="KittenClientEndpoints.BaseUrl.WebSocketDefault"/></para>
    /// </summary>
    public string KittenClientWebSocketEndpoints { get; set; } = KittenClientEndpoints.BaseUrl.WebSocketDefault;
}