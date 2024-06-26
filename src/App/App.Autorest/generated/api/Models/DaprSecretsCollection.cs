// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>Dapr component Secrets Collection for ListSecrets Action.</summary>
    public partial class DaprSecretsCollection :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDaprSecretsCollection,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDaprSecretsCollectionInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDaprSecret> _value;

        /// <summary>Collection of secrets used by a Dapr component</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDaprSecret> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DaprSecretsCollection" /> instance.</summary>
        public DaprSecretsCollection()
        {

        }
    }
    /// Dapr component Secrets Collection for ListSecrets Action.
    public partial interface IDaprSecretsCollection :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>Collection of secrets used by a Dapr component</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Collection of secrets used by a Dapr component",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDaprSecret) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDaprSecret> Value { get; set; }

    }
    /// Dapr component Secrets Collection for ListSecrets Action.
    internal partial interface IDaprSecretsCollectionInternal

    {
        /// <summary>Collection of secrets used by a Dapr component</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDaprSecret> Value { get; set; }

    }
}