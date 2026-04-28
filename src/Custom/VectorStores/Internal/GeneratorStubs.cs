using Microsoft.TypeSpec.Generator.Customizations;
using System.ClientModel;

namespace OpenAI.VectorStores;

// CUSTOM: Made internal.
[CodeGenType("CreateVectorStoreFileRequest")] public partial class InternalCreateVectorStoreFileRequest { }
[CodeGenType("ListVectorStoreFilesResponse")] public partial class InternalListVectorStoreFilesResponse : IInternalListResponse<VectorStoreFile> { }
[CodeGenType("ListVectorStoresResponse")] public partial class InternalListVectorStoresResponse : IInternalListResponse<VectorStore> { }
[CodeGenType("VectorStoreFileBatchObjectFileCounts")] public partial class InternalVectorStoreFileBatchObjectFileCounts { }
[CodeGenType("StaticChunkingStrategy")] public partial class InternalStaticChunkingStrategy { }
[CodeGenType("ChunkingStrategyRequestParam")] public partial class InternalChunkingStrategyRequestParam { }
[CodeGenType("ChunkingStrategyRequestParamType")] public readonly partial struct InternalChunkingStrategyRequestParamType {}
[CodeGenType("AutoChunkingStrategyRequestParam")] public partial class InternalAutoChunkingStrategyRequestParam { }
[CodeGenType("StaticChunkingStrategyRequestParam")] public partial class InternalStaticChunkingStrategyRequestParam { }
[CodeGenType("UnknownChunkingStrategyRequestParam")] public partial class InternalUnknownChunkingStrategyRequestParamProxy { }
[CodeGenType("ChunkingStrategyResponse")] public partial class InternalChunkingStrategyResponseParam { }
[CodeGenType("ChunkingStrategyResponseType")] public readonly partial struct InternalChunkingStrategyResponseParamType { }
[CodeGenType("StaticChunkingStrategyResponseParam")] public partial class InternalStaticChunkingStrategyResponseParam { }
[CodeGenType("OtherChunkingStrategyResponseParam")] public partial class InternalOtherChunkingStrategyResponseParam { }
[CodeGenType("DotNetCombinedAutoChunkingStrategyParam")] public partial class InternalDotNetCombinedAutoChunkingStrategyParam { }
[CodeGenType("DotNetCombinedChunkingStrategyParamType")] public readonly partial struct InternalDotNetCombinedChunkingStrategyParamType { }
[CodeGenType("DotNetCombinedChunkingStrategyParamType3")] public readonly partial struct InternalDotNetCombinedChunkingStrategyParamType3 { }
[CodeGenType("UnknownDotNetCombinedChunkingStrategyParam")] public partial class InternalUnknownDotNetCombinedChunkingStrategyParam { }
[CodeGenType("DotNetCombinedOtherChunkingStrategyParam")] public partial class InternalDotNetCombinedOtherChunkingStrategyParam { }
[CodeGenType("UnknownChunkingStrategyResponse")] public partial class InternalUnknownChunkingStrategyResponseParam { }
[CodeGenType("VectorStoreFileAttributes")] public partial class InternalVectorStoreFileAttributes { }
[CodeGenType("VectorStoreSearchRequestRankingOptionsRanker")] public readonly partial struct InternalVectorStoreSearchRequestRankingOptionsRanker {}
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
[CodeGenType("VectorStoreFileContentResponse")] public partial class InternalVectorStoreFileContentResponse {}
[CodeGenType("VectorStoreFileContentResponseData")] public partial class InternalVectorStoreFileContentResponseDatum {}
[CodeGenType("VectorStoreSearchRequestRankingOptions")] public partial class InternalVectorStoreSearchRequestRankingOptions {}
[CodeGenType("VectorStoreSearchRequest")] public partial class InternalVectorStoreSearchRequest {}
[CodeGenType("VectorStoreSearchResultsPage")] public partial class InternalVectorStoreSearchResultsPage {}
[CodeGenType("VectorStoreSearchResultItem")] public partial class InternalVectorStoreSearchResultItem {}
[CodeGenType("VectorStoreSearchResultContentObject")] public partial class InternalVectorStoreSearchResultContentObject {}
[CodeGenType("Metadata")] public partial class InternalMetadata { }