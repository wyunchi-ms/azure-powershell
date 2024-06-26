// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>Azure Active Directory Partner Client Authentication</summary>
    public partial class AzureAdPartnerClientAuthentication :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAzureAdPartnerClientAuthentication,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAzureAdPartnerClientAuthenticationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerClientAuthentication"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerClientAuthentication __partnerClientAuthentication = new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.PartnerClientAuthentication();

        /// <summary>
        /// The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in
        /// delivery requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string AzureActiveDirectoryApplicationIdOrUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAzureAdPartnerClientAuthenticationPropertiesInternal)Property).AzureActiveDirectoryApplicationIdOrUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAzureAdPartnerClientAuthenticationPropertiesInternal)Property).AzureActiveDirectoryApplicationIdOrUri = value ?? null; }

        /// <summary>
        /// The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string AzureActiveDirectoryTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAzureAdPartnerClientAuthenticationPropertiesInternal)Property).AzureActiveDirectoryTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAzureAdPartnerClientAuthenticationPropertiesInternal)Property).AzureActiveDirectoryTenantId = value ?? null; }

        /// <summary>Type of client authentication</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inherited)]
        public string ClientAuthenticationType { get => "AzureAD"; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAzureAdPartnerClientAuthenticationProperties Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAzureAdPartnerClientAuthenticationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.AzureAdPartnerClientAuthenticationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ClientAuthenticationType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerClientAuthenticationInternal.ClientAuthenticationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerClientAuthenticationInternal)__partnerClientAuthentication).ClientAuthenticationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerClientAuthenticationInternal)__partnerClientAuthentication).ClientAuthenticationType = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAzureAdPartnerClientAuthenticationProperties _property;

        /// <summary>AzureAD ClientAuthentication Properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAzureAdPartnerClientAuthenticationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.AzureAdPartnerClientAuthenticationProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="AzureAdPartnerClientAuthentication" /> instance.</summary>
        public AzureAdPartnerClientAuthentication()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__partnerClientAuthentication), __partnerClientAuthentication);
            await eventListener.AssertObjectIsValid(nameof(__partnerClientAuthentication), __partnerClientAuthentication);
        }
    }
    /// Azure Active Directory Partner Client Authentication
    public partial interface IAzureAdPartnerClientAuthentication :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerClientAuthentication
    {
        /// <summary>
        /// The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in
        /// delivery requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in delivery requests.",
        SerializedName = @"azureActiveDirectoryApplicationIdOrUri",
        PossibleTypes = new [] { typeof(string) })]
        string AzureActiveDirectoryApplicationIdOrUri { get; set; }
        /// <summary>
        /// The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests.",
        SerializedName = @"azureActiveDirectoryTenantId",
        PossibleTypes = new [] { typeof(string) })]
        string AzureActiveDirectoryTenantId { get; set; }

    }
    /// Azure Active Directory Partner Client Authentication
    internal partial interface IAzureAdPartnerClientAuthenticationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerClientAuthenticationInternal
    {
        /// <summary>
        /// The Azure Active Directory Application ID or URI to get the access token that will be included as the bearer token in
        /// delivery requests.
        /// </summary>
        string AzureActiveDirectoryApplicationIdOrUri { get; set; }
        /// <summary>
        /// The Azure Active Directory Tenant ID to get the access token that will be included as the bearer token in delivery requests.
        /// </summary>
        string AzureActiveDirectoryTenantId { get; set; }
        /// <summary>AzureAD ClientAuthentication Properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IAzureAdPartnerClientAuthenticationProperties Property { get; set; }

    }
}