using Microsoft.TypeSpec.Generator.Customizations;

namespace OpenAI.Videos;

// CUSTOM:
// - Renamed.
// - Made internal until we support the convenience methods.
[CodeGenType("VideoContentVariant")]
public readonly partial struct InternalVideoContentVariant
{
}
