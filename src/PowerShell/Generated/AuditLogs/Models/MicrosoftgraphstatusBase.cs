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
    /// statusBase
    /// </summary>
    public partial class MicrosoftgraphstatusBase
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphstatusBase class.
        /// </summary>
        public MicrosoftgraphstatusBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphstatusBase class.
        /// </summary>
        /// <param name="status">Possible values include: 'success', 'failure',
        /// 'skipped', 'unknownFutureValue'</param>
        public MicrosoftgraphstatusBase(string status = default(string))
        {
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'success', 'failure',
        /// 'skipped', 'unknownFutureValue'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}