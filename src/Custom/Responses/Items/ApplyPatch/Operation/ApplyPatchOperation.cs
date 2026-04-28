// <GP>
// Minimal models for the OpenAI Responses "apply_patch" tool output.
// We keep this local and small to avoid broad changes to the vendored SDK.
// </GP>

#nullable disable

using System;
using System.Text.Json;

namespace OpenAI.Responses;

// <GP>
public sealed class ApplyPatchOperation
{
    public string Type { get; set; }
    public string Path { get; set; }
    public string Diff { get; set; }

    internal static ApplyPatchOperation FromJsonElement(JsonElement element)
    {
        if (element.ValueKind != JsonValueKind.Object)
        {
            return null;
        }

        ApplyPatchOperation op = new();
        if (element.TryGetProperty("type"u8, out JsonElement typeEl) && typeEl.ValueKind == JsonValueKind.String)
        {
            op.Type = typeEl.GetString();
        }
        if (element.TryGetProperty("path"u8, out JsonElement pathEl) && pathEl.ValueKind == JsonValueKind.String)
        {
            op.Path = pathEl.GetString();
        }
        if (element.TryGetProperty("diff"u8, out JsonElement diffEl) && diffEl.ValueKind == JsonValueKind.String)
        {
            op.Diff = diffEl.GetString();
        }

        return op;
    }

    internal void Write(Utf8JsonWriter writer)
    {
        writer.WriteStartObject();
        if (!string.IsNullOrEmpty(Type))
        {
            writer.WriteString("type"u8, Type);
        }
        if (!string.IsNullOrEmpty(Path))
        {
            writer.WriteString("path"u8, Path);
        }
        if (Diff != null)
        {
            writer.WriteString("diff"u8, Diff);
        }
        writer.WriteEndObject();
    }
}
// </GP>
