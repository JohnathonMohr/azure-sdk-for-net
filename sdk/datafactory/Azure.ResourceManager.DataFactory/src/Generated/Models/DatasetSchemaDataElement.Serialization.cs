// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    [JsonConverter(typeof(DatasetSchemaDataElementConverter))]
    public partial class DatasetSchemaDataElement : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SchemaColumnName))
            {
                writer.WritePropertyName("name"u8);
                JsonSerializer.Serialize(writer, SchemaColumnName);
            }
            if (Optional.IsDefined(SchemaColumnType))
            {
                writer.WritePropertyName("type"u8);
                JsonSerializer.Serialize(writer, SchemaColumnType);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static DatasetSchemaDataElement DeserializeDatasetSchemaDataElement(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<string>> name = default;
            Optional<DataFactoryElement<string>> type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DatasetSchemaDataElement(name.Value, type.Value, additionalProperties);
        }

        internal partial class DatasetSchemaDataElementConverter : JsonConverter<DatasetSchemaDataElement>
        {
            public override void Write(Utf8JsonWriter writer, DatasetSchemaDataElement model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DatasetSchemaDataElement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDatasetSchemaDataElement(document.RootElement);
            }
        }
    }
}
