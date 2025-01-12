// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Contains information for manual implementation for an Azure SQL Database, Server or Elastic Pool Recommended Action. </summary>
    public partial class RecommendedActionImplementationInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RecommendedActionImplementationInfo"/>. </summary>
        internal RecommendedActionImplementationInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecommendedActionImplementationInfo"/>. </summary>
        /// <param name="method"> Gets the method in which this recommended action can be manually implemented. e.g., TSql, AzurePowerShell. </param>
        /// <param name="script"> Gets the manual implementation script. e.g., T-SQL script that could be executed on the database. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecommendedActionImplementationInfo(ImplementationMethod? method, string script, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Method = method;
            Script = script;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the method in which this recommended action can be manually implemented. e.g., TSql, AzurePowerShell. </summary>
        public ImplementationMethod? Method { get; }
        /// <summary> Gets the manual implementation script. e.g., T-SQL script that could be executed on the database. </summary>
        public string Script { get; }
    }
}
