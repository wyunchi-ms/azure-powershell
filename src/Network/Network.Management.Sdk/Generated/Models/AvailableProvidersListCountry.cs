// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Country details.
    /// </summary>
    public partial class AvailableProvidersListCountry
    {
        /// <summary>
        /// Initializes a new instance of the AvailableProvidersListCountry class.
        /// </summary>
        public AvailableProvidersListCountry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableProvidersListCountry class.
        /// </summary>

        /// <param name="countryName">The country name.
        /// </param>

        /// <param name="providers">A list of Internet service providers.
        /// </param>

        /// <param name="states">List of available states in the country.
        /// </param>
        public AvailableProvidersListCountry(string countryName = default(string), System.Collections.Generic.IList<string> providers = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<AvailableProvidersListState> states = default(System.Collections.Generic.IList<AvailableProvidersListState>))

        {
            this.CountryName = countryName;
            this.Providers = providers;
            this.States = states;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the country name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "countryName")]
        public string CountryName {get; set; }

        /// <summary>
        /// Gets or sets a list of Internet service providers.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "providers")]
        public System.Collections.Generic.IList<string> Providers {get; set; }

        /// <summary>
        /// Gets or sets list of available states in the country.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "states")]
        public System.Collections.Generic.IList<AvailableProvidersListState> States {get; set; }
    }
}