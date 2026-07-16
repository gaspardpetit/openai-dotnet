using Microsoft.TypeSpec.Generator.Customizations;

namespace OpenAI.Assistants;

[CodeGenType("MessageDeltaContentImageFileObjectImageFile")]
public partial class InternalMessageDeltaContentImageFileObjectImageFile
{
    [CodeGenMember("Detail")]
    internal string Detail { get; set; }
}
