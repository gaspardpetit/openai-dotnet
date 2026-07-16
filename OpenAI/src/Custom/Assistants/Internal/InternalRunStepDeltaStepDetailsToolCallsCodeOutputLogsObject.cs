using Microsoft.TypeSpec.Generator.Customizations;

namespace OpenAI.Assistants;

[CodeGenType("RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject")]
public partial class InternalRunStepDeltaStepDetailsToolCallsCodeOutputLogsObject
{
    [CodeGenMember("Logs")]
    public string InternalLogs { get; set; }
}
