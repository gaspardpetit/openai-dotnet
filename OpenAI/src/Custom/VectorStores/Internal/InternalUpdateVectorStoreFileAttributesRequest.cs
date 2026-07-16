using Microsoft.TypeSpec.Generator.Customizations;
using System.ClientModel;

namespace OpenAI.VectorStores;

[CodeGenType("UpdateVectorStoreFileAttributesRequest")] public partial class InternalUpdateVectorStoreFileAttributesRequest
{
    public static implicit operator BinaryContent(InternalUpdateVectorStoreFileAttributesRequest internalUpdateVectorStoreFileAttributesRequest)
    {
        if (internalUpdateVectorStoreFileAttributesRequest == null)
        {
            return null;
        }
        return BinaryContent.Create(internalUpdateVectorStoreFileAttributesRequest, ModelSerializationExtensions.WireOptions);
    }
}
