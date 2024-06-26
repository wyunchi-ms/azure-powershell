// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Extensions;

    /// <summary>Parameters describes the request to regenerate access keys</summary>
    public partial class RegenerateKeyParameters :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IRegenerateKeyParameters,
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IRegenerateKeyParametersInternal
    {

        /// <summary>Backing field for <see cref="KeyType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.KeyType? _keyType;

        /// <summary>The type of access key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.KeyType? KeyType { get => this._keyType; set => this._keyType = value; }

        /// <summary>Creates an new <see cref="RegenerateKeyParameters" /> instance.</summary>
        public RegenerateKeyParameters()
        {

        }
    }
    /// Parameters describes the request to regenerate access keys
    public partial interface IRegenerateKeyParameters :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.IJsonSerializable
    {
        /// <summary>The type of access key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of access key.",
        SerializedName = @"keyType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.KeyType) })]
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.KeyType? KeyType { get; set; }

    }
    /// Parameters describes the request to regenerate access keys
    internal partial interface IRegenerateKeyParametersInternal

    {
        /// <summary>The type of access key.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.KeyType? KeyType { get; set; }

    }
}