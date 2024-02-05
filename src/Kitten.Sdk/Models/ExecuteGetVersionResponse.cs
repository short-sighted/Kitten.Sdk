using System.Text.Json.Serialization;

namespace Kitten.Sdk.Models;

public class ExecuteGetVersionResponse
{
    /// <summary>
    /// 是否为Meta
    /// </summary>
    [JsonPropertyName("meta")]
    public bool? Meta { get; set; } = default;

    /// <summary>
    /// 版本号
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; } = default;
}