// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Store.PartnerCenter.PowerShell.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftgraphplannerBucket
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphplannerBucket
        /// class.
        /// </summary>
        public MicrosoftgraphplannerBucket()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphplannerBucket
        /// class.
        /// </summary>
        public MicrosoftgraphplannerBucket(string id = default(string), string name = default(string), string planId = default(string), string orderHint = default(string), IList<MicrosoftgraphplannerTask> tasks = default(IList<MicrosoftgraphplannerTask>))
        {
            Id = id;
            Name = name;
            PlanId = planId;
            OrderHint = orderHint;
            Tasks = tasks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "planId")]
        public string PlanId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderHint")]
        public string OrderHint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tasks")]
        public IList<MicrosoftgraphplannerTask> Tasks { get; set; }

    }
}