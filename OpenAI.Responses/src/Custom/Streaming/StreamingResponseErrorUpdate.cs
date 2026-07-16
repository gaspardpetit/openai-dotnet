using Microsoft.TypeSpec.Generator.Customizations;

namespace OpenAI.Responses;

// CUSTOM: Renamed.
[CodeGenType("ResponseErrorEvent")]
public partial class StreamingResponseErrorUpdate
{
    // <GP> Preserve the provider-specific type from nested streaming error payloads.
    /// <summary> Gets the provider-specific error type. </summary>
    public string ErrorType { get; internal set; }
    // </GP>
}
