using Microsoft.TypeSpec.Generator.Customizations;

namespace OpenAI.Assistants;

[CodeGenType("MessageContentImageUrlObjectImageUrl")]
public partial class InternalMessageContentImageUrlObjectImageUrl
{
    [CodeGenMember("Detail")]
    internal string Detail { get; }
}
