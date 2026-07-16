using Microsoft.TypeSpec.Generator.Customizations;

namespace OpenAI.FineTuning;

[CodeGenType("FineTuningJobEventLevel")]
public enum FineTuningJobEventLevel
{
    Info,
    Warn,
    Error
}
