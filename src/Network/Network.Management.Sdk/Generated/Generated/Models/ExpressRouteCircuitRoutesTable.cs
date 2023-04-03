// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The routes table associated with the ExpressRouteCircuit.
    /// </summary>
    public partial class ExpressRouteCircuitRoutesTable
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitRoutesTable
        /// class.
        /// </summary>
        public ExpressRouteCircuitRoutesTable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitRoutesTable
        /// class.
        /// </summary>
        /// <param name="network">IP address of a network entity.</param>
        /// <param name="nextHop">NextHop address.</param>
        /// <param name="locPrf">Local preference value as set with the set
        /// local-preference route-map configuration command.</param>
        /// <param name="weight">Route Weight.</param>
        /// <param name="path">Autonomous system paths to the destination
        /// network.</param>
        public ExpressRouteCircuitRoutesTable(string network = default(string), string nextHop = default(string), string locPrf = default(string), int? weight = default(int?), string path = default(string))
        {
            Network = network;
            NextHop = nextHop;
            LocPrf = locPrf;
            Weight = weight;
            Path = path;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets IP address of a network entity.
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string Network { get; set; }

        /// <summary>
        /// Gets or sets nextHop address.
        /// </summary>
        [JsonProperty(PropertyName = "nextHop")]
        public string NextHop { get; set; }

        /// <summary>
        /// Gets or sets local preference value as set with the set
        /// local-preference route-map configuration command.
        /// </summary>
        [JsonProperty(PropertyName = "locPrf")]
        public string LocPrf { get; set; }

        /// <summary>
        /// Gets or sets route Weight.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or sets autonomous system paths to the destination network.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

    }
}
