// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Extensions;

    /// <summary>The List Cluster Keys Results appliance.</summary>
    public partial class ApplianceListKeysResults
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject into a new instance of <see cref="ApplianceListKeysResults" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ApplianceListKeysResults(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_artifactProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject>("artifactProfiles"), out var __jsonArtifactProfiles) ? Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ApplianceListKeysResultsArtifactProfiles.FromJson(__jsonArtifactProfiles) : ArtifactProfile;}
            {_kubeconfig = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonArray>("kubeconfigs"), out var __jsonKubeconfigs) ? If( __jsonKubeconfigs as Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.IApplianceCredentialKubeconfig[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.IApplianceCredentialKubeconfig) (Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ApplianceCredentialKubeconfig.FromJson(__u) )) ))() : null : Kubeconfig;}
            {_sshKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject>("sshKeys"), out var __jsonSshKeys) ? Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ApplianceListKeysResultsSshKeys.FromJson(__jsonSshKeys) : SshKey;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.IApplianceListKeysResults.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.IApplianceListKeysResults.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.IApplianceListKeysResults FromJson(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject json ? new ApplianceListKeysResults(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ApplianceListKeysResults" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ApplianceListKeysResults" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._artifactProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonNode) this._artifactProfile.ToJson(null,serializationMode) : null, "artifactProfiles" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._kubeconfig)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.XNodeArray();
                    foreach( var __x in this._kubeconfig )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("kubeconfigs",__w);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._sshKey ? (Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Json.JsonNode) this._sshKey.ToJson(null,serializationMode) : null, "sshKeys" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}