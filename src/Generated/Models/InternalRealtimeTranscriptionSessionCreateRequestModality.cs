// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Realtime
{
    internal readonly partial struct InternalRealtimeTranscriptionSessionCreateRequestModality : IEquatable<InternalRealtimeTranscriptionSessionCreateRequestModality>
    {
        private readonly string _value;
        private const string TextValue = "text";
        private const string AudioValue = "audio";

        public InternalRealtimeTranscriptionSessionCreateRequestModality(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        internal static InternalRealtimeTranscriptionSessionCreateRequestModality Text { get; } = new InternalRealtimeTranscriptionSessionCreateRequestModality(TextValue);

        internal static InternalRealtimeTranscriptionSessionCreateRequestModality Audio { get; } = new InternalRealtimeTranscriptionSessionCreateRequestModality(AudioValue);

        public static bool operator ==(InternalRealtimeTranscriptionSessionCreateRequestModality left, InternalRealtimeTranscriptionSessionCreateRequestModality right) => left.Equals(right);

        public static bool operator !=(InternalRealtimeTranscriptionSessionCreateRequestModality left, InternalRealtimeTranscriptionSessionCreateRequestModality right) => !left.Equals(right);

        public static implicit operator InternalRealtimeTranscriptionSessionCreateRequestModality(string value) => new InternalRealtimeTranscriptionSessionCreateRequestModality(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalRealtimeTranscriptionSessionCreateRequestModality other && Equals(other);

        public bool Equals(InternalRealtimeTranscriptionSessionCreateRequestModality other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
