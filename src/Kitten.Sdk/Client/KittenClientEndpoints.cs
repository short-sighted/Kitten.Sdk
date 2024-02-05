namespace Kitten.Sdk.Client;

/// <summary>
/// Kitten请求地址
/// </summary>
public static class KittenClientEndpoints
{
    /// <summary>
    /// Url
    /// </summary>
    public static class BaseUrl
    {
        /// <summary>
        /// Http默认地址
        /// </summary>
        public const string HttpDefault = "http://127.0.0.1:8080/";
        /// <summary>
        /// WebSocket默认地址
        /// </summary>
        public const string WebSocketDefault = "ws://127.0.0.1:8080/";
    }
    
    /// <summary>
    /// 端点
    /// </summary>
    public static class EndPoints
    {
        /// <summary>
        /// 版本
        /// </summary>
        public const string Version = "version";
    }
}