// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachineRunDataExtractsParameters represents the body of request containing list of curated data extraction commands to run on the bare metal machine. </summary>
    public partial class BareMetalMachineRunDataExtractsContent
    {
        /// <summary> Initializes a new instance of BareMetalMachineRunDataExtractsContent. </summary>
        /// <param name="commands"> The list of curated data extraction commands to be executed directly against the target machine. </param>
        /// <param name="limitTimeSeconds">
        /// The maximum time the commands are allowed to run.
        /// If the execution time exceeds the maximum, the script will be stopped, any output produced until then will be captured, and the exit code matching a timeout will be returned (252).
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="commands"/> is null. </exception>
        public BareMetalMachineRunDataExtractsContent(IEnumerable<BareMetalMachineCommandSpecification> commands, long limitTimeSeconds)
        {
            Argument.AssertNotNull(commands, nameof(commands));

            Commands = commands.ToList();
            LimitTimeSeconds = limitTimeSeconds;
        }

        /// <summary> The list of curated data extraction commands to be executed directly against the target machine. </summary>
        public IList<BareMetalMachineCommandSpecification> Commands { get; }
        /// <summary>
        /// The maximum time the commands are allowed to run.
        /// If the execution time exceeds the maximum, the script will be stopped, any output produced until then will be captured, and the exit code matching a timeout will be returned (252).
        /// </summary>
        public long LimitTimeSeconds { get; }
    }
}
