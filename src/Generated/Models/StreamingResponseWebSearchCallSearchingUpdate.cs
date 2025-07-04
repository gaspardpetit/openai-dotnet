// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    public partial class StreamingResponseWebSearchCallSearchingUpdate : StreamingResponseUpdate
    {
        internal StreamingResponseWebSearchCallSearchingUpdate(int sequenceNumber, int outputIndex, string itemId) : base(InternalResponseStreamEventType.ResponseWebSearchCallSearching, sequenceNumber)
        {
            OutputIndex = outputIndex;
            ItemId = itemId;
        }

        internal StreamingResponseWebSearchCallSearchingUpdate(InternalResponseStreamEventType kind, int sequenceNumber, IDictionary<string, BinaryData> additionalBinaryDataProperties, int outputIndex, string itemId) : base(kind, sequenceNumber, additionalBinaryDataProperties)
        {
            OutputIndex = outputIndex;
            ItemId = itemId;
        }

        public int OutputIndex { get; }

        public string ItemId { get; }
    }
}
