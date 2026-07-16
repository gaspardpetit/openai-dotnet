using Microsoft.TypeSpec.Generator.Customizations;

namespace OpenAI.Assistants;

[CodeGenType("MessageDeltaObjectDelta")]
public partial class InternalMessageDeltaObjectDelta
{
    [CodeGenMember("Role")]
    internal MessageRole? Role { get; }
}
