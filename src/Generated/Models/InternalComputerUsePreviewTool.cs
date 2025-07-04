// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    internal partial class InternalComputerUsePreviewTool : ResponseTool
    {
        public InternalComputerUsePreviewTool(ComputerToolEnvironment environment, int displayWidth, int displayHeight) : base(InternalToolType.ComputerUsePreview)
        {
            Environment = environment;
            DisplayWidth = displayWidth;
            DisplayHeight = displayHeight;
        }

        internal InternalComputerUsePreviewTool(InternalToolType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, ComputerToolEnvironment environment, int displayWidth, int displayHeight) : base(kind, additionalBinaryDataProperties)
        {
            Environment = environment;
            DisplayWidth = displayWidth;
            DisplayHeight = displayHeight;
        }

        public ComputerToolEnvironment Environment { get; set; }

        public int DisplayWidth { get; set; }

        public int DisplayHeight { get; set; }
    }
}
