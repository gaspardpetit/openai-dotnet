using Microsoft.TypeSpec.Generator.Customizations;

namespace OpenAI.Assistants;

[CodeGenType("MessageDeltaContentImageUrlObjectImageUrl")]
public partial class InternalMessageDeltaContentImageUrlObjectImageUrl
{
    [CodeGenMember("Detail")]
    internal string Detail { get; }
}
