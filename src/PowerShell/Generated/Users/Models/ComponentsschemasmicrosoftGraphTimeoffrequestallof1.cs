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
    using System.Linq;

    /// <summary>
    /// timeOffRequest
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphTimeoffrequestallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphTimeoffrequestallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphTimeoffrequestallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphTimeoffrequestallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphTimeoffrequestallof1(System.DateTime? startDateTime = default(System.DateTime?), System.DateTime? endDateTime = default(System.DateTime?), string timeOffReasonId = default(string))
        {
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            TimeOffReasonId = timeOffReasonId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startDateTime")]
        public System.DateTime? StartDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endDateTime")]
        public System.DateTime? EndDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeOffReasonId")]
        public string TimeOffReasonId { get; set; }

    }
}