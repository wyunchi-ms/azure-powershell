// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>Network Tap Rule Patch properties.</summary>
    public partial class NetworkTapRulePatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource __annotationResource = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.AnnotationResource();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchableProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchableProperties __networkTapRulePatchableProperties = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.NetworkTapRulePatchableProperties();

        /// <summary>Switch configuration description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public string Annotation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)__annotationResource).Annotation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)__annotationResource).Annotation = value ?? null; }

        /// <summary>Input method to configure Network Tap Rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public string ConfigurationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchablePropertiesInternal)__networkTapRulePatchableProperties).ConfigurationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchablePropertiesInternal)__networkTapRulePatchableProperties).ConfigurationType = value ?? null; }

        /// <summary>List of dynamic match configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ICommonDynamicMatchConfiguration> DynamicMatchConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchablePropertiesInternal)__networkTapRulePatchableProperties).DynamicMatchConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchablePropertiesInternal)__networkTapRulePatchableProperties).DynamicMatchConfiguration = value ?? null /* arrayOf */; }

        /// <summary>List of match configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRuleMatchConfiguration> MatchConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchablePropertiesInternal)__networkTapRulePatchableProperties).MatchConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchablePropertiesInternal)__networkTapRulePatchableProperties).MatchConfiguration = value ?? null /* arrayOf */; }

        /// <summary>Network Tap Rules file URL.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public string TapRulesUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchablePropertiesInternal)__networkTapRulePatchableProperties).TapRulesUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchablePropertiesInternal)__networkTapRulePatchableProperties).TapRulesUrl = value ?? null; }

        /// <summary>Creates an new <see cref="NetworkTapRulePatchProperties" /> instance.</summary>
        public NetworkTapRulePatchProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__annotationResource), __annotationResource);
            await eventListener.AssertObjectIsValid(nameof(__annotationResource), __annotationResource);
            await eventListener.AssertNotNull(nameof(__networkTapRulePatchableProperties), __networkTapRulePatchableProperties);
            await eventListener.AssertObjectIsValid(nameof(__networkTapRulePatchableProperties), __networkTapRulePatchableProperties);
        }
    }
    /// Network Tap Rule Patch properties.
    public partial interface INetworkTapRulePatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchableProperties
    {

    }
    /// Network Tap Rule Patch properties.
    internal partial interface INetworkTapRulePatchPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapRulePatchablePropertiesInternal
    {

    }
}