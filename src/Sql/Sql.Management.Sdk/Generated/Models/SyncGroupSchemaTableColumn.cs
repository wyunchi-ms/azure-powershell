// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of column in sync group table.
    /// </summary>
    public partial class SyncGroupSchemaTableColumn
    {
        /// <summary>
        /// Initializes a new instance of the SyncGroupSchemaTableColumn class.
        /// </summary>
        public SyncGroupSchemaTableColumn()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SyncGroupSchemaTableColumn class.
        /// </summary>

        /// <param name="quotedName">Quoted name of sync group table column.
        /// </param>

        /// <param name="dataSize">Data size of the column.
        /// </param>

        /// <param name="dataType">Data type of the column.
        /// </param>
        public SyncGroupSchemaTableColumn(string quotedName = default(string), string dataSize = default(string), string dataType = default(string))

        {
            this.QuotedName = quotedName;
            this.DataSize = dataSize;
            this.DataType = dataType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets quoted name of sync group table column.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "quotedName")]
        public string QuotedName {get; set; }

        /// <summary>
        /// Gets or sets data size of the column.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dataSize")]
        public string DataSize {get; set; }

        /// <summary>
        /// Gets or sets data type of the column.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dataType")]
        public string DataType {get; set; }
    }
}