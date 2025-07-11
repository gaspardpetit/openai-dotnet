// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal partial class InternalListFineTuningJobEventsResponse
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalListFineTuningJobEventsResponse(IEnumerable<FineTuningEvent> data, bool hasMore)
        {
            Data = data.ToList();
            HasMore = hasMore;
        }

        internal InternalListFineTuningJobEventsResponse(IList<FineTuningEvent> data, string @object, bool hasMore, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            Data = data ?? new ChangeTrackingList<FineTuningEvent>();
            Object = @object;
            HasMore = hasMore;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public IList<FineTuningEvent> Data { get; }

        public string Object { get; } = "list";

        public bool HasMore { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
