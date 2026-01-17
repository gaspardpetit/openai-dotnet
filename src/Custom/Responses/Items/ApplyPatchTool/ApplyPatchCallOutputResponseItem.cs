// <GP>
// Minimal models for the OpenAI Responses "apply_patch_call_output" input items.
// </GP>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses;

// <GP>
[CodeGenType("ApplyPatchCallOutput")]
public partial class ApplyPatchCallOutputResponseItem : ResponseItem
{
    public string CallId { get; set; }
    public string Status { get; set; }
    public string Output { get; set; }

    public ApplyPatchCallOutputResponseItem(string callId, string status, string output = null)
        : base(new InternalItemType("apply_patch_call_output"))
    {
        Argument.AssertNotNull(callId, nameof(callId));
        Argument.AssertNotNull(status, nameof(status));
        CallId = callId;
        Status = status;
        Output = output;
    }

#pragma warning disable SCME0001 // Type is for evaluation purposes only and is subject to change or removal in future updates.
    internal ApplyPatchCallOutputResponseItem(InternalItemType kind, string id, in JsonPatch patch, string status, string callId, string output)
        : base(kind, id, patch)
    {
        Status = status;
        CallId = callId;
        Output = output;
    }
#pragma warning restore SCME0001 // Type is for evaluation purposes only and is subject to change or removal in future updates.

    protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        string format = options.Format == "W" ? ((IPersistableModel<ResponseItem>)this).GetFormatFromOptions(options) : options.Format;
        if (format != "J")
        {
            throw new FormatException($"The model {nameof(ApplyPatchCallOutputResponseItem)} does not support writing '{format}' format.");
        }

        base.JsonModelWriteCore(writer, options);

#pragma warning disable SCME0001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
        if (!Patch.Contains("$.call_id"u8))
        {
            writer.WritePropertyName("call_id"u8);
            writer.WriteStringValue(CallId);
        }

        if (!Patch.Contains("$.status"u8))
        {
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status);
        }

        if (!Patch.Contains("$.output"u8) && Output != null)
        {
            writer.WritePropertyName("output"u8);
            writer.WriteStringValue(Output);
        }

        Patch.WriteTo(writer);
#pragma warning restore SCME0001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
    }

    internal static ApplyPatchCallOutputResponseItem DeserializeApplyPatchCallOutputResponseItem(JsonElement element, BinaryData data, ModelReaderWriterOptions options)
    {
        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }

        InternalItemType kind = default;
        string id = default;
        string status = default;
        string callId = default;
        string output = default;

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

            if (prop.NameEquals("output"u8))
            {
                output = prop.Value.ValueKind == JsonValueKind.String ? prop.Value.GetString() : null;
                continue;
            }

            patch.Set([.. "$."u8, .. Encoding.UTF8.GetBytes(prop.Name)], prop.Value.GetUtf8Bytes());
        }

        return new ApplyPatchCallOutputResponseItem(kind, id, patch, status, callId, output);
    }
}
// </GP>
