using Microsoft.TypeSpec.Generator.Customizations;

namespace OpenAI.Images;

// CUSTOM: Made internal.

[CodeGenType("ImagesResponseBackground")] public readonly partial struct InternalImagesResponseBackground { }
[CodeGenType("ImagesResponseOutputFormat")] public readonly partial struct InternalImagesResponseOutputFormat { }
[CodeGenType("ImagesResponseQuality")] public readonly partial struct InternalImagesResponseQuality { }
[CodeGenType("ImagesResponseSize")] public readonly partial struct InternalImagesResponseSize { }

// Image generation.
[CodeGenType("CreateImageRequestModel")] public readonly partial struct InternalCreateImageRequestModel { }

// Image edit generation.
[CodeGenType("CreateImageEditRequestBackground")] public readonly partial struct InternalCreateImageEditRequestBackground { }
[CodeGenType("CreateImageEditRequestModel")] public readonly partial struct InternalCreateImageEditRequestModel { }
[CodeGenType("CreateImageEditRequestOutputFormat")] public readonly partial struct InternalCreateImageEditRequestOutputFormat { }
[CodeGenType("CreateImageEditRequestQuality")] public readonly partial struct InternalCreateImageEditRequestQuality { }
[CodeGenType("CreateImageEditRequestResponseFormat")] public readonly partial struct InternalCreateImageEditRequestResponseFormat { }
[CodeGenType("CreateImageEditRequestSize")] public readonly partial struct InternalCreateImageEditRequestSize { }

// Image variation generation.
[CodeGenType("CreateImageVariationRequestModel")] public readonly partial struct InternalCreateImageVariationRequestModel { }
[CodeGenType("CreateImageVariationRequestResponseFormat")] public readonly partial struct InternalCreateImageVariationRequestResponseFormat { }
[CodeGenType("CreateImageVariationRequestSize")] public readonly partial struct InternalCreateImageVariationRequestSize { }

// Streaming image generation.
[CodeGenType("ImageGenPartialImageEvent")] public partial class InternalImageGenPartialImageEvent { }
[CodeGenType("ImageGenCompletedEvent")] public partial class InternalImageGenCompletedEvent { }
[CodeGenType("ImageGenPartialImageEventBackground")] public readonly partial struct InternalImageGenPartialImageEventBackground { }
[CodeGenType("ImageGenPartialImageEventOutputFormat")] public readonly partial struct InternalImageGenPartialImageEventOutputFormat { }
[CodeGenType("ImageGenPartialImageEventQuality")] public readonly partial struct InternalImageGenPartialImageEventQuality { }
[CodeGenType("ImageGenPartialImageEventSize")] public readonly partial struct InternalImageGenPartialImageEventSize { }
[CodeGenType("ImageGenCompletedEventBackground")] public readonly partial struct InternalImageGenCompletedEventBackground { }
[CodeGenType("ImageGenCompletedEventOutputFormat")] public readonly partial struct InternalImageGenCompletedEventOutputFormat { }
[CodeGenType("ImageGenCompletedEventQuality")] public readonly partial struct InternalImageGenCompletedEventQuality { }
[CodeGenType("ImageGenCompletedEventSize")] public readonly partial struct InternalImageGenCompletedEventSize { }
[CodeGenType("ImagesUsage")] public partial class InternalImagesUsage { }
[CodeGenType("ImagesUsageInputTokensDetails")] public partial class InternalImagesUsageInputTokensDetails { }

// Streaming image edit generation.
[CodeGenType("ImageEditPartialImageEvent")] public partial class InternalImageEditPartialImageEvent { }
[CodeGenType("ImageEditCompletedEvent")] public partial class InternalImageEditCompletedEvent { }
[CodeGenType("ImageEditPartialImageEventBackground")] public readonly partial struct InternalImageEditPartialImageEventBackground { }
[CodeGenType("ImageEditPartialImageEventOutputFormat")] public readonly partial struct InternalImageEditPartialImageEventOutputFormat { }
[CodeGenType("ImageEditPartialImageEventQuality")] public readonly partial struct InternalImageEditPartialImageEventQuality { }
[CodeGenType("ImageEditPartialImageEventSize")] public readonly partial struct InternalImageEditPartialImageEventSize { }
[CodeGenType("ImageEditCompletedEventBackground")] public readonly partial struct InternalImageEditCompletedEventBackground { }
[CodeGenType("ImageEditCompletedEventOutputFormat")] public readonly partial struct InternalImageEditCompletedEventOutputFormat { }
[CodeGenType("ImageEditCompletedEventQuality")] public readonly partial struct InternalImageEditCompletedEventQuality { }
[CodeGenType("ImageEditCompletedEventSize")] public readonly partial struct InternalImageEditCompletedEventSize { }