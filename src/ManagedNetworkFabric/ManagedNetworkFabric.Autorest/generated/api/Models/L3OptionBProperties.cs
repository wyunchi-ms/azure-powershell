// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>Option B configuration.</summary>
    public partial class L3OptionBProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL3OptionBProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL3OptionBPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ExportRouteTarget" /> property.</summary>
        private System.Collections.Generic.List<string> _exportRouteTarget;

        /// <summary>RouteTargets to be applied. This is used for the backward compatibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ExportRouteTarget { get => this._exportRouteTarget; set => this._exportRouteTarget = value; }

        /// <summary>Backing field for <see cref="ImportRouteTarget" /> property.</summary>
        private System.Collections.Generic.List<string> _importRouteTarget;

        /// <summary>RouteTargets to be applied. This is used for the backward compatibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ImportRouteTarget { get => this._importRouteTarget; set => this._importRouteTarget = value; }

        /// <summary>Backing field for <see cref="RouteTarget" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRouteTargetInformation _routeTarget;

        /// <summary>RouteTargets to be applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRouteTargetInformation RouteTarget { get => (this._routeTarget = this._routeTarget ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.RouteTargetInformation()); set => this._routeTarget = value; }

        /// <summary>Creates an new <see cref="L3OptionBProperties" /> instance.</summary>
        public L3OptionBProperties()
        {

        }
    }
    /// Option B configuration.
    public partial interface IL3OptionBProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable
    {
        /// <summary>RouteTargets to be applied. This is used for the backward compatibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"RouteTargets to be applied. This is used for the backward compatibility.",
        SerializedName = @"exportRouteTargets",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ExportRouteTarget { get; set; }
        /// <summary>RouteTargets to be applied. This is used for the backward compatibility.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"RouteTargets to be applied. This is used for the backward compatibility.",
        SerializedName = @"importRouteTargets",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ImportRouteTarget { get; set; }
        /// <summary>RouteTargets to be applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"RouteTargets to be applied.",
        SerializedName = @"routeTargets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRouteTargetInformation) })]
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRouteTargetInformation RouteTarget { get; set; }

    }
    /// Option B configuration.
    internal partial interface IL3OptionBPropertiesInternal

    {
        /// <summary>RouteTargets to be applied. This is used for the backward compatibility.</summary>
        System.Collections.Generic.List<string> ExportRouteTarget { get; set; }
        /// <summary>RouteTargets to be applied. This is used for the backward compatibility.</summary>
        System.Collections.Generic.List<string> ImportRouteTarget { get; set; }
        /// <summary>RouteTargets to be applied.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IRouteTargetInformation RouteTarget { get; set; }

    }
}