using Microsoft.TypeSpec.Generator.Customizations;
using System.ClientModel;

namespace OpenAI.Files;

// CUSTOM: Renamed.
[CodeGenType("CreateUploadRequest")]
public partial class InternalCreateUploadRequest
{
    public static implicit operator BinaryContent(InternalCreateUploadRequest internalCreateUploadRequest)
    {
        if (internalCreateUploadRequest == null)
        {
            return null;
        }
        return BinaryContent.Create(internalCreateUploadRequest, ModelSerializationExtensions.WireOptions);
    }
}
