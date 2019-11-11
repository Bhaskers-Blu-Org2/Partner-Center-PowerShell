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

    /// <summary>
    /// directoryAudit
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphDirectoryauditallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphDirectoryauditallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphDirectoryauditallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphDirectoryauditallof1 class.
        /// </summary>
        /// <param name="result">Possible values include: 'success', 'failure',
        /// 'timeout', 'unknownFutureValue'</param>
        public ComponentsschemasmicrosoftGraphDirectoryauditallof1(string category = default(string), string correlationId = default(string), string result = default(string), string resultReason = default(string), string activityDisplayName = default(string), System.DateTime? activityDateTime = default(System.DateTime?), string loggedByService = default(string), string operationType = default(string), MicrosoftgraphauditActivityInitiator initiatedBy = default(MicrosoftgraphauditActivityInitiator), IList<MicrosoftgraphtargetResource> targetResources = default(IList<MicrosoftgraphtargetResource>), IList<MicrosoftgraphkeyValue> additionalDetails = default(IList<MicrosoftgraphkeyValue>))
        {
            Category = category;
            CorrelationId = correlationId;
            Result = result;
            ResultReason = resultReason;
            ActivityDisplayName = activityDisplayName;
            ActivityDateTime = activityDateTime;
            LoggedByService = loggedByService;
            OperationType = operationType;
            InitiatedBy = initiatedBy;
            TargetResources = targetResources;
            AdditionalDetails = additionalDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "correlationId")]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'success', 'failure',
        /// 'timeout', 'unknownFutureValue'
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resultReason")]
        public string ResultReason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityDisplayName")]
        public string ActivityDisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityDateTime")]
        public System.DateTime? ActivityDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "loggedByService")]
        public string LoggedByService { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operationType")]
        public string OperationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "initiatedBy")]
        public MicrosoftgraphauditActivityInitiator InitiatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetResources")]
        public IList<MicrosoftgraphtargetResource> TargetResources { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additionalDetails")]
        public IList<MicrosoftgraphkeyValue> AdditionalDetails { get; set; }

    }
}