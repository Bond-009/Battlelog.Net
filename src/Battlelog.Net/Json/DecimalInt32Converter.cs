using System;
using System.Buffers;
using System.Buffers.Text;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Battlelog.Json
{
    public class DecimalInt32Converter : JsonConverter<int>
    {
        private static ReadOnlySpan<byte> DecimalZero => new byte[] { (byte)'0', (byte)'.', (byte)'0' };

        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
            if (span.SequenceEqual(DecimalZero))
            {
                return 0;
            }

            if (reader.TokenType == JsonTokenType.String)
            {
                if (Utf8Parser.TryParse(span, out int value, out _))
                {
                    return value;
                }

                throw new FormatException($"Invalid integer format: '{Encoding.UTF8.GetChars(span.ToArray())}' Position: {reader.Position}");
            }

            return reader.GetInt32();
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
}
