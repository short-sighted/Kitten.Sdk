using System.Text.Json.Serialization;

namespace Kitten.Sdk.Models;

public class ExecuteGetStatusResponse
{
    /// <summary>
    /// 测试
    /// </summary>
    [JsonPropertyName("hello")]
    public string? Hello { get; set; } = default;
}