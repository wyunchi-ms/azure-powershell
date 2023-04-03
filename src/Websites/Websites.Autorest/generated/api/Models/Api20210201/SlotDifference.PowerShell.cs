// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.PowerShell;

    /// <summary>A setting difference between two deployment slots of an app.</summary>
    [System.ComponentModel.TypeConverter(typeof(SlotDifferenceTypeConverter))]
    public partial class SlotDifference
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.SlotDifference"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifference" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifference DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SlotDifference(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.SlotDifference"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifference" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifference DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SlotDifference(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SlotDifference" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SlotDifference" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifference FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.SlotDifference"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SlotDifference(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.SlotDifferencePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Level"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).Level = (string) content.GetValueForProperty("Level",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).Level, global::System.Convert.ToString);
            }
            if (content.Contains("SettingType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).SettingType = (string) content.GetValueForProperty("SettingType",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).SettingType, global::System.Convert.ToString);
            }
            if (content.Contains("DiffRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).DiffRule = (string) content.GetValueForProperty("DiffRule",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).DiffRule, global::System.Convert.ToString);
            }
            if (content.Contains("SettingName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).SettingName = (string) content.GetValueForProperty("SettingName",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).SettingName, global::System.Convert.ToString);
            }
            if (content.Contains("ValueInCurrentSlot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).ValueInCurrentSlot = (string) content.GetValueForProperty("ValueInCurrentSlot",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).ValueInCurrentSlot, global::System.Convert.ToString);
            }
            if (content.Contains("ValueInTargetSlot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).ValueInTargetSlot = (string) content.GetValueForProperty("ValueInTargetSlot",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).ValueInTargetSlot, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).Description, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.SlotDifference"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SlotDifference(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.SlotDifferencePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Level"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).Level = (string) content.GetValueForProperty("Level",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).Level, global::System.Convert.ToString);
            }
            if (content.Contains("SettingType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).SettingType = (string) content.GetValueForProperty("SettingType",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).SettingType, global::System.Convert.ToString);
            }
            if (content.Contains("DiffRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).DiffRule = (string) content.GetValueForProperty("DiffRule",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).DiffRule, global::System.Convert.ToString);
            }
            if (content.Contains("SettingName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).SettingName = (string) content.GetValueForProperty("SettingName",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).SettingName, global::System.Convert.ToString);
            }
            if (content.Contains("ValueInCurrentSlot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).ValueInCurrentSlot = (string) content.GetValueForProperty("ValueInCurrentSlot",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).ValueInCurrentSlot, global::System.Convert.ToString);
            }
            if (content.Contains("ValueInTargetSlot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).ValueInTargetSlot = (string) content.GetValueForProperty("ValueInTargetSlot",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).ValueInTargetSlot, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISlotDifferenceInternal)this).Description, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// A setting difference between two deployment slots of an app.
    [System.ComponentModel.TypeConverter(typeof(SlotDifferenceTypeConverter))]
    public partial interface ISlotDifference

    {

    }
}