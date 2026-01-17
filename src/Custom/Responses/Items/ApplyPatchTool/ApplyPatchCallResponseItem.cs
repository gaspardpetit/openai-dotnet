// <GP>
// Minimal models for the OpenAI Responses "apply_patch" tool output items.
// The upstream SDK currently does not expose these types; we add a small shim.
// </GP>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses;

// <GP>
[CodeGenType("ApplyPatchCall")]
public partial class ApplyPatchCallResponseItem : ResponseItem
{
    public string Status { get; set; }
    public string CallId { get; set; }
    public ApplyPatchOperation Operation { get; set; }

    public ApplyPatchCallResponseItem() : base(new InternalItemType("apply_patch_call"))
    {
    }

#pragma warning disable SCME0001 // Type is for evaluation purposes only and is subject to change or removal in future updates.
    internal ApplyPatchCallResponseItem(InternalItemType kind, string id, in JsonPatch patch, string status, string callId, ApplyPatchOperation operation)
        : base(kind, id, patch)
    {
        Status = status;
        CallId = callId;
        Operation = operation;
    }
#pragma warning restore SCME0001 // Type is for evaluation purposes only and is subject to change or removal in future updates.

    protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        string format = options.Format == "W" ? ((IPersistableModel<ResponseItem>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(ApplyPatchCallResponseItem)} does not support writing '{format}' format.");
        }

        base.JsonModelWriteCore(writer, options);

#pragma warning disable SCME0001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
        if (!Patch.Contains("$.status"u8) && !string.IsNullOrEmpty(Status))
        {
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status);
        }

        if (!Patch.Contains("$.call_id"u8) && !string.IsNullOrEmpty(CallId))
        {
            writer.WritePropertyName("call_id"u8);
            writer.WriteStringValue(CallId);
        }

        if (!Patch.Contains("$.operation"u8) && Operation != null)
        {
            writer.WritePropertyName("operation"u8);
            Operation.Write(writer);
        }

        Patch.WriteTo(writer);
#pragma warning restore SCME0001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
    }

    internal static ApplyPatchCallResponseItem DeserializeApplyPatchCallResponseItem(JsonElement element, BinaryData data, ModelReaderWriterOptions options)
    {
        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }

        InternalItemType kind = default;
        string id = default;
        string status = default;
        string callId = default;
        ApplyPatchOperation operation = null;

#pragma warning disable SCME0001 // Type is for evaluation purposes only and is subject to change or removal in future updates.
        JsonPatch patch = new JsonPatch(data is null ? ReadOnlyMemory<byte>.Empty : data.ToMemory());
#pragma warning restore SCME0001 // Type is for evaluation purposes only and is subject to change or removal in future updates.

        foreach (var prop in element.EnumerateObject())
        {
            if (prop.NameEquals("type"u8))
            {
                kind = new InternalItemType(prop.Value.GetString());
                continue;
            }

            if (prop.NameEquals("id"u8))
            {
                id = prop.Value.GetString();
                continue;
            }

            if (prop.NameEquals("status"u8))
            {
                status = prop.Value.ValueKind == JsonValueKind.String ? prop.Value.GetString() : null;
                continue;
            }

            if (prop.NameEquals("call_id"u8))
            {
                callId = prop.Value.ValueKind == JsonValueKind.String ? prop.Value.GetString() : null;
                continue;
            }

            if (prop.NameEquals("operation"u8))
            {
                operation = ApplyPatchOperation.FromJsonElement(prop.Value);
                continue;
            }

            patch.Set([.. "$."u8, .. Encoding.UTF8.GetBytes(prop.Name)], prop.Value.GetUtf8Bytes());
        }

        return new ApplyPatchCallResponseItem(kind, id, patch, status, callId, operation);
    }
}
// </GP>
