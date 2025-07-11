// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    public partial class StreamingResponseErrorUpdate : StreamingResponseUpdate
    {
        internal StreamingResponseErrorUpdate(int sequenceNumber, string errorType, string code, string message, string @param) : base(InternalResponseStreamEventType.Error, sequenceNumber)
        {
            ErrorType = errorType;
            Code = code;
            Message = message;
            Param = @param;
        }

        internal StreamingResponseErrorUpdate(InternalResponseStreamEventType kind, int sequenceNumber, IDictionary<string, BinaryData> additionalBinaryDataProperties, string errorType, string code, string message, string @param) : base(kind, sequenceNumber, additionalBinaryDataProperties)
        {
            ErrorType = errorType;
			Code = code;
            Message = message;
            Param = @param;
        }

		public string ErrorType { get; }

        public string Code { get; }

        public string Message { get; }

        public string Param { get; }
    }
}
