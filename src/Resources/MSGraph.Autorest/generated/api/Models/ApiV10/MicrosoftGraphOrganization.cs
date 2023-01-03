// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>organization</summary>
    public partial class MicrosoftGraphOrganization :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOrganization,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOrganizationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject __microsoftGraphDirectoryObject = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphDirectoryObject();

        /// <summary>Backing field for <see cref="AssignedPlan" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAssignedPlan[] _assignedPlan;

        /// <summary>The collection of service plans associated with the tenant. Not nullable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAssignedPlan[] AssignedPlan { get => this._assignedPlan; set => this._assignedPlan = value; }

        /// <summary>Backing field for <see cref="Branding" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOrganizationalBranding _branding;

        /// <summary>organizationalBranding</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOrganizationalBranding Branding { get => (this._branding = this._branding ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphOrganizationalBranding()); set => this._branding = value; }

        /// <summary>Backing field for <see cref="BusinessPhone" /> property.</summary>
        private string[] _businessPhone;

        /// <summary>
        /// Telephone number for the organization. Although this is a string collection, only one number can be set for this property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string[] BusinessPhone { get => this._businessPhone; set => this._businessPhone = value; }

        /// <summary>Backing field for <see cref="CertificateBasedAuthConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphCertificateBasedAuthConfiguration[] _certificateBasedAuthConfiguration;

        /// <summary>
        /// Navigation property to manage certificate-based authentication configuration. Only a single instance of certificateBasedAuthConfiguration
        /// can be created in the collection.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphCertificateBasedAuthConfiguration[] CertificateBasedAuthConfiguration { get => this._certificateBasedAuthConfiguration; set => this._certificateBasedAuthConfiguration = value; }

        /// <summary>Backing field for <see cref="City" /> property.</summary>
        private string _city;

        /// <summary>City name of the address for the organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string City { get => this._city; set => this._city = value; }

        /// <summary>Backing field for <see cref="Country" /> property.</summary>
        private string _country;

        /// <summary>Country/region name of the address for the organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Country { get => this._country; set => this._country = value; }

        /// <summary>Backing field for <see cref="CountryLetterCode" /> property.</summary>
        private string _countryLetterCode;

        /// <summary>Country or region abbreviation for the organization in ISO 3166-2 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string CountryLetterCode { get => this._countryLetterCode; set => this._countryLetterCode = value; }

        /// <summary>Backing field for <see cref="CreatedDateTime" /> property.</summary>
        private global::System.DateTime? _createdDateTime;

        /// <summary>
        /// Timestamp of when the organization was created. The value cannot be modified and is automatically populated when the organization
        /// is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For
        /// example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedDateTime { get => this._createdDateTime; set => this._createdDateTime = value; }

        /// <summary>
        /// Date and time when this object was deleted. Always null when the object hasn't been deleted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public global::System.DateTime? DeletedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal)__microsoftGraphDirectoryObject).DeletedDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal)__microsoftGraphDirectoryObject).DeletedDateTime = value ?? default(global::System.DateTime); }

        /// <summary>The name displayed in directory</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal)__microsoftGraphDirectoryObject).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal)__microsoftGraphDirectoryObject).DisplayName = value ?? null; }

        /// <summary>Backing field for <see cref="Extension" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphExtension[] _extension;

        /// <summary>
        /// The collection of open extensions defined for the organization. Read-only. Nullable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphExtension[] Extension { get => this._extension; set => this._extension = value; }

        /// <summary>Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityAutoGeneratedInternal)__microsoftGraphDirectoryObject).Id; }

        /// <summary>Backing field for <see cref="MarketingNotificationEmail" /> property.</summary>
        private string[] _marketingNotificationEmail;

        /// <summary>Not nullable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string[] MarketingNotificationEmail { get => this._marketingNotificationEmail; set => this._marketingNotificationEmail = value; }

        /// <summary>Internal Acessors for OdataId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal.OdataId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal)__microsoftGraphDirectoryObject).OdataId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal)__microsoftGraphDirectoryObject).OdataId = value; }

        /// <summary>Internal Acessors for OdataType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal.OdataType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal)__microsoftGraphDirectoryObject).OdataType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal)__microsoftGraphDirectoryObject).OdataType = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityAutoGeneratedInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityAutoGeneratedInternal)__microsoftGraphDirectoryObject).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityAutoGeneratedInternal)__microsoftGraphDirectoryObject).Id = value; }

        /// <summary>Backing field for <see cref="MobileDeviceManagementAuthority" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Support.MdmAuthority? _mobileDeviceManagementAuthority;

        /// <summary>Mobile device management authority.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Support.MdmAuthority? MobileDeviceManagementAuthority { get => this._mobileDeviceManagementAuthority; set => this._mobileDeviceManagementAuthority = value; }

        /// <summary>The full id of object in directory</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public string OdataId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal)__microsoftGraphDirectoryObject).OdataId; }

        /// <summary>The type of object in directory</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public string OdataType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal)__microsoftGraphDirectoryObject).OdataType; }

        /// <summary>Backing field for <see cref="OnPremisesLastSyncDateTime" /> property.</summary>
        private global::System.DateTime? _onPremisesLastSyncDateTime;

        /// <summary>
        /// The time and date at which the tenant was last synced with the on-premises directory. The Timestamp type represents date
        /// and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public global::System.DateTime? OnPremisesLastSyncDateTime { get => this._onPremisesLastSyncDateTime; set => this._onPremisesLastSyncDateTime = value; }

        /// <summary>Backing field for <see cref="OnPremisesSyncEnabled" /> property.</summary>
        private bool? _onPremisesSyncEnabled;

        /// <summary>
        /// true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises
        /// directory but is no longer synced. Nullable. null if this object has never been synced from an on-premises directory (default).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public bool? OnPremisesSyncEnabled { get => this._onPremisesSyncEnabled; set => this._onPremisesSyncEnabled = value; }

        /// <summary>Backing field for <see cref="PostalCode" /> property.</summary>
        private string _postalCode;

        /// <summary>Postal code of the address for the organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string PostalCode { get => this._postalCode; set => this._postalCode = value; }

        /// <summary>Backing field for <see cref="PreferredLanguage" /> property.</summary>
        private string _preferredLanguage;

        /// <summary>
        /// The preferred language for the organization. Should follow ISO 639-1 Code; for example, en.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string PreferredLanguage { get => this._preferredLanguage; set => this._preferredLanguage = value; }

        /// <summary>Backing field for <see cref="PrivacyProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPrivacyProfile _privacyProfile;

        /// <summary>privacyProfile</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPrivacyProfile PrivacyProfile { get => (this._privacyProfile = this._privacyProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphPrivacyProfile()); set => this._privacyProfile = value; }

        /// <summary>Backing field for <see cref="ProvisionedPlan" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphProvisionedPlan[] _provisionedPlan;

        /// <summary>Not nullable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphProvisionedPlan[] ProvisionedPlan { get => this._provisionedPlan; set => this._provisionedPlan = value; }

        /// <summary>Backing field for <see cref="SecurityComplianceNotificationMail" /> property.</summary>
        private string[] _securityComplianceNotificationMail;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string[] SecurityComplianceNotificationMail { get => this._securityComplianceNotificationMail; set => this._securityComplianceNotificationMail = value; }

        /// <summary>Backing field for <see cref="SecurityComplianceNotificationPhone" /> property.</summary>
        private string[] _securityComplianceNotificationPhone;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string[] SecurityComplianceNotificationPhone { get => this._securityComplianceNotificationPhone; set => this._securityComplianceNotificationPhone = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>State name of the address for the organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="Street" /> property.</summary>
        private string _street;

        /// <summary>Street name of the address for organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Street { get => this._street; set => this._street = value; }

        /// <summary>Backing field for <see cref="TechnicalNotificationMail" /> property.</summary>
        private string[] _technicalNotificationMail;

        /// <summary>Not nullable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string[] TechnicalNotificationMail { get => this._technicalNotificationMail; set => this._technicalNotificationMail = value; }

        /// <summary>Backing field for <see cref="TenantType" /> property.</summary>
        private string _tenantType;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string TenantType { get => this._tenantType; set => this._tenantType = value; }

        /// <summary>Backing field for <see cref="VerifiedDomain" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphVerifiedDomain[] _verifiedDomain;

        /// <summary>The collection of domains associated with this tenant. Not nullable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphVerifiedDomain[] VerifiedDomain { get => this._verifiedDomain; set => this._verifiedDomain = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphOrganization" /> instance.</summary>
        public MicrosoftGraphOrganization()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__microsoftGraphDirectoryObject), __microsoftGraphDirectoryObject);
            await eventListener.AssertObjectIsValid(nameof(__microsoftGraphDirectoryObject), __microsoftGraphDirectoryObject);
        }
    }
    /// organization
    public partial interface IMicrosoftGraphOrganization :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>The collection of service plans associated with the tenant. Not nullable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of service plans associated with the tenant. Not nullable.",
        SerializedName = @"assignedPlans",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAssignedPlan) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAssignedPlan[] AssignedPlan { get; set; }
        /// <summary>organizationalBranding</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"organizationalBranding",
        SerializedName = @"branding",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOrganizationalBranding) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOrganizationalBranding Branding { get; set; }
        /// <summary>
        /// Telephone number for the organization. Although this is a string collection, only one number can be set for this property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Telephone number for the organization. Although this is a string collection, only one number can be set for this property.",
        SerializedName = @"businessPhones",
        PossibleTypes = new [] { typeof(string) })]
        string[] BusinessPhone { get; set; }
        /// <summary>
        /// Navigation property to manage certificate-based authentication configuration. Only a single instance of certificateBasedAuthConfiguration
        /// can be created in the collection.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Navigation property to manage certificate-based authentication configuration. Only a single instance of certificateBasedAuthConfiguration can be created in the collection.",
        SerializedName = @"certificateBasedAuthConfiguration",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphCertificateBasedAuthConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphCertificateBasedAuthConfiguration[] CertificateBasedAuthConfiguration { get; set; }
        /// <summary>City name of the address for the organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"City name of the address for the organization.",
        SerializedName = @"city",
        PossibleTypes = new [] { typeof(string) })]
        string City { get; set; }
        /// <summary>Country/region name of the address for the organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Country/region name of the address for the organization.",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string Country { get; set; }
        /// <summary>Country or region abbreviation for the organization in ISO 3166-2 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Country or region abbreviation for the organization in ISO 3166-2 format.",
        SerializedName = @"countryLetterCode",
        PossibleTypes = new [] { typeof(string) })]
        string CountryLetterCode { get; set; }
        /// <summary>
        /// Timestamp of when the organization was created. The value cannot be modified and is automatically populated when the organization
        /// is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For
        /// example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Timestamp of when the organization was created. The value cannot be modified and is automatically populated when the organization is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.",
        SerializedName = @"createdDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedDateTime { get; set; }
        /// <summary>
        /// The collection of open extensions defined for the organization. Read-only. Nullable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of open extensions defined for the organization. Read-only. Nullable.",
        SerializedName = @"extensions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphExtension) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphExtension[] Extension { get; set; }
        /// <summary>Not nullable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Not nullable.",
        SerializedName = @"marketingNotificationEmails",
        PossibleTypes = new [] { typeof(string) })]
        string[] MarketingNotificationEmail { get; set; }
        /// <summary>Mobile device management authority.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mobile device management authority.",
        SerializedName = @"mobileDeviceManagementAuthority",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Support.MdmAuthority) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Support.MdmAuthority? MobileDeviceManagementAuthority { get; set; }
        /// <summary>
        /// The time and date at which the tenant was last synced with the on-premises directory. The Timestamp type represents date
        /// and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time and date at which the tenant was last synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.",
        SerializedName = @"onPremisesLastSyncDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? OnPremisesLastSyncDateTime { get; set; }
        /// <summary>
        /// true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises
        /// directory but is no longer synced. Nullable. null if this object has never been synced from an on-premises directory (default).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced. Nullable. null if this object has never been synced from an on-premises directory (default).",
        SerializedName = @"onPremisesSyncEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? OnPremisesSyncEnabled { get; set; }
        /// <summary>Postal code of the address for the organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Postal code of the address for the organization.",
        SerializedName = @"postalCode",
        PossibleTypes = new [] { typeof(string) })]
        string PostalCode { get; set; }
        /// <summary>
        /// The preferred language for the organization. Should follow ISO 639-1 Code; for example, en.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The preferred language for the organization. Should follow ISO 639-1 Code; for example, en.",
        SerializedName = @"preferredLanguage",
        PossibleTypes = new [] { typeof(string) })]
        string PreferredLanguage { get; set; }
        /// <summary>privacyProfile</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"privacyProfile",
        SerializedName = @"privacyProfile",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPrivacyProfile) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPrivacyProfile PrivacyProfile { get; set; }
        /// <summary>Not nullable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Not nullable.",
        SerializedName = @"provisionedPlans",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphProvisionedPlan) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphProvisionedPlan[] ProvisionedPlan { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"securityComplianceNotificationMails",
        PossibleTypes = new [] { typeof(string) })]
        string[] SecurityComplianceNotificationMail { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"securityComplianceNotificationPhones",
        PossibleTypes = new [] { typeof(string) })]
        string[] SecurityComplianceNotificationPhone { get; set; }
        /// <summary>State name of the address for the organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State name of the address for the organization.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }
        /// <summary>Street name of the address for organization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Street name of the address for organization.",
        SerializedName = @"street",
        PossibleTypes = new [] { typeof(string) })]
        string Street { get; set; }
        /// <summary>Not nullable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Not nullable.",
        SerializedName = @"technicalNotificationMails",
        PossibleTypes = new [] { typeof(string) })]
        string[] TechnicalNotificationMail { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tenantType",
        PossibleTypes = new [] { typeof(string) })]
        string TenantType { get; set; }
        /// <summary>The collection of domains associated with this tenant. Not nullable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of domains associated with this tenant. Not nullable.",
        SerializedName = @"verifiedDomains",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphVerifiedDomain) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphVerifiedDomain[] VerifiedDomain { get; set; }

    }
    /// organization
    internal partial interface IMicrosoftGraphOrganizationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObjectInternal
    {
        /// <summary>The collection of service plans associated with the tenant. Not nullable.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAssignedPlan[] AssignedPlan { get; set; }
        /// <summary>organizationalBranding</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOrganizationalBranding Branding { get; set; }
        /// <summary>
        /// Telephone number for the organization. Although this is a string collection, only one number can be set for this property.
        /// </summary>
        string[] BusinessPhone { get; set; }
        /// <summary>
        /// Navigation property to manage certificate-based authentication configuration. Only a single instance of certificateBasedAuthConfiguration
        /// can be created in the collection.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphCertificateBasedAuthConfiguration[] CertificateBasedAuthConfiguration { get; set; }
        /// <summary>City name of the address for the organization.</summary>
        string City { get; set; }
        /// <summary>Country/region name of the address for the organization.</summary>
        string Country { get; set; }
        /// <summary>Country or region abbreviation for the organization in ISO 3166-2 format.</summary>
        string CountryLetterCode { get; set; }
        /// <summary>
        /// Timestamp of when the organization was created. The value cannot be modified and is automatically populated when the organization
        /// is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For
        /// example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        global::System.DateTime? CreatedDateTime { get; set; }
        /// <summary>
        /// The collection of open extensions defined for the organization. Read-only. Nullable.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphExtension[] Extension { get; set; }
        /// <summary>Not nullable.</summary>
        string[] MarketingNotificationEmail { get; set; }
        /// <summary>Mobile device management authority.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Support.MdmAuthority? MobileDeviceManagementAuthority { get; set; }
        /// <summary>
        /// The time and date at which the tenant was last synced with the on-premises directory. The Timestamp type represents date
        /// and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// Read-only.
        /// </summary>
        global::System.DateTime? OnPremisesLastSyncDateTime { get; set; }
        /// <summary>
        /// true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises
        /// directory but is no longer synced. Nullable. null if this object has never been synced from an on-premises directory (default).
        /// </summary>
        bool? OnPremisesSyncEnabled { get; set; }
        /// <summary>Postal code of the address for the organization.</summary>
        string PostalCode { get; set; }
        /// <summary>
        /// The preferred language for the organization. Should follow ISO 639-1 Code; for example, en.
        /// </summary>
        string PreferredLanguage { get; set; }
        /// <summary>privacyProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPrivacyProfile PrivacyProfile { get; set; }
        /// <summary>Not nullable.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphProvisionedPlan[] ProvisionedPlan { get; set; }

        string[] SecurityComplianceNotificationMail { get; set; }

        string[] SecurityComplianceNotificationPhone { get; set; }
        /// <summary>State name of the address for the organization.</summary>
        string State { get; set; }
        /// <summary>Street name of the address for organization.</summary>
        string Street { get; set; }
        /// <summary>Not nullable.</summary>
        string[] TechnicalNotificationMail { get; set; }

        string TenantType { get; set; }
        /// <summary>The collection of domains associated with this tenant. Not nullable.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphVerifiedDomain[] VerifiedDomain { get; set; }

    }
}