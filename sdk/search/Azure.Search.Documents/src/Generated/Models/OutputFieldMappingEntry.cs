// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Output field mapping for a skill. </summary>
    public partial class OutputFieldMappingEntry
    {
        /// <summary> Initializes a new instance of OutputFieldMappingEntry. </summary>
        /// <param name="name"> The name of the output defined by the skill. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public OutputFieldMappingEntry(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of OutputFieldMappingEntry. </summary>
        /// <param name="name"> The name of the output defined by the skill. </param>
        /// <param name="targetName"> The target name of the output. It is optional and default to name. </param>
        internal OutputFieldMappingEntry(string name, string targetName)
        {
            Name = name;
            TargetName = targetName;
        }

        /// <summary> The name of the output defined by the skill. </summary>
        public string Name { get; set; }
        /// <summary> The target name of the output. It is optional and default to name. </summary>
        public string TargetName { get; set; }
    }
}
