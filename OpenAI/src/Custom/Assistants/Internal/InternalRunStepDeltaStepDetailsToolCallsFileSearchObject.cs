using Microsoft.TypeSpec.Generator.Customizations;

namespace OpenAI.Assistants;

[CodeGenType("RunStepDeltaStepDetailsToolCallsFileSearchObject")]
public partial class InternalRunStepDeltaStepDetailsToolCallsFileSearchObject
{
    [CodeGenMember("FileSearch")]
    public InternalRunStepDetailsToolCallsFileSearchObjectFileSearch FileSearch { get; set; }
}
