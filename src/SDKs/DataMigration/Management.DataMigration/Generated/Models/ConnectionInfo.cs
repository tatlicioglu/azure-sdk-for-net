// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the connection properties of a server
    /// </summary>
    [Newtonsoft.Json.JsonObject("Unknown")]
    public partial class ConnectionInfo
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionInfo class.
        /// </summary>
        public ConnectionInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionInfo class.
        /// </summary>
        /// <param name="userName">User name</param>
        /// <param name="password">Password credential.</param>
        public ConnectionInfo(string userName = default(string), string password = default(string))
        {
            UserName = userName;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user name
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets password credential.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

    }
}
