// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters used when creating a sync group.
    /// </summary>
    public partial class SyncGroupCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the SyncGroupCreateParameters class.
        /// </summary>
        public SyncGroupCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SyncGroupCreateParameters class.
        /// </summary>
        /// <param name="location">Required. Gets or sets the location of the
        /// resource. This will be one of the supported and registered Azure
        /// Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo
        /// region of a resource cannot be changed once it is created, but if
        /// an identical geo region is specified on update, the request will
        /// succeed.</param>
        /// <param name="tags">Gets or sets a list of key value pairs that
        /// describe the resource. These tags can be used for viewing and
        /// grouping this resource (across resource groups). A maximum of 15
        /// tags can be provided for a resource. Each tag must have a key with
        /// a length no greater than 128 characters and a value with a length
        /// no greater than 256 characters.</param>
        /// <param name="properties">The parameters used to create the sync
        /// group</param>
        public SyncGroupCreateParameters(string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), object properties = default(object))
        {
            Location = location;
            Tags = tags;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets required. Gets or sets the location of the resource.
        /// This will be one of the supported and registered Azure Geo Regions
        /// (e.g. West US, East US, Southeast Asia, etc.). The geo region of a
        /// resource cannot be changed once it is created, but if an identical
        /// geo region is specified on update, the request will succeed.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// These tags can be used for viewing and grouping this resource
        /// (across resource groups). A maximum of 15 tags can be provided for
        /// a resource. Each tag must have a key with a length no greater than
        /// 128 characters and a value with a length no greater than 256
        /// characters.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the parameters used to create the sync group
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

    }
}
