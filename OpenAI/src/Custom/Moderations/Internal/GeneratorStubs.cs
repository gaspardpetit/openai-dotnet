using Microsoft.TypeSpec.Generator.Customizations;

namespace OpenAI.Moderations;

[CodeGenType("CreateModerationRequestModel")]
public readonly partial struct InternalCreateModerationRequestModel { }

[CodeGenType("CreateModerationResponseResultsCategories")]
public partial class InternalModerationCategories { }

[CodeGenType("CreateModerationResponseResultsCategoryScores")]
public partial class InternalModerationCategoryScores { }

[CodeGenType("ModerationImageURLInput")]
public partial class InternalModerationImagePart { }

[CodeGenType("ModerationImageURLInputImageUrl")]
public partial class InternalModerationImagePartImageUrl { }

[CodeGenType("UnknownCreateModerationRequestInput")]
public partial class InternalUnknownModerationInputPart { }
