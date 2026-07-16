using Microsoft.TypeSpec.Generator.Customizations;

namespace OpenAI.FineTuning;

[CodeGenType("CreateFineTuningJobRequestWandbIntegrationWandb")]
public partial class InternalCreateFineTuningJobRequestWandbIntegrationWandb
{
    [CodeGenMember("Project")]
    public string Project { get; set; }
}
