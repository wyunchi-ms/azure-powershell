// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The QueueStatus of Agent Pool</summary>
    public partial class AgentPoolQueueStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolQueueStatus,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPoolQueueStatusInternal
    {

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private int? _count;

        /// <summary>The number of pending runs in the queue</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public int? Count { get => this._count; set => this._count = value; }

        /// <summary>Creates an new <see cref="AgentPoolQueueStatus" /> instance.</summary>
        public AgentPoolQueueStatus()
        {

        }
    }
    /// The QueueStatus of Agent Pool
    public partial interface IAgentPoolQueueStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The number of pending runs in the queue</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of pending runs in the queue",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int? Count { get; set; }

    }
    /// The QueueStatus of Agent Pool
    internal partial interface IAgentPoolQueueStatusInternal

    {
        /// <summary>The number of pending runs in the queue</summary>
        int? Count { get; set; }

    }
}