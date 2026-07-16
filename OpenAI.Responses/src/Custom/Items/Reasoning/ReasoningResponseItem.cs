using Microsoft.TypeSpec.Generator.Customizations;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Responses;

// CUSTOM: Renamed.
[CodeGenType("ReasoningItemResource")]
public partial class ReasoningResponseItem
{
    // CUSTOM:
    // - Made nullable because this is an optional property.
    // - Added setter because this is an optional property in an input/output type.
    [CodeGenMember("Status")]
    public ReasoningStatus? Status { get; set; }

    // CUSTOM: Added for convenience.
    public ReasoningResponseItem(string summaryText) : this(summaryParts: [new ReasoningSummaryTextPart(summaryText)])
    {
        Argument.AssertNotNull(summaryText, nameof(summaryText));
    }

    // <GP> Added constructor for providing encrypted reasoning content.
    /// <summary> Initializes a reasoning item with encrypted reasoning content. </summary>
    public ReasoningResponseItem(string id, IReadOnlyList<ReasoningSummaryPart> summaryParts, string encryptedContent)
        : this(ResponseItemKind.Reasoning, id, default, null, encryptedContent, summaryParts?.ToList())
    {
        Argument.AssertNotNull(summaryParts, nameof(summaryParts));
    }
    // </GP>

    // CUSTOM: Added for convenience.
    public string GetSummaryText()
    {
        return string.Concat(values: SummaryParts.Select(part => (part as ReasoningSummaryTextPart)?.Text ?? string.Empty));
    }
}
