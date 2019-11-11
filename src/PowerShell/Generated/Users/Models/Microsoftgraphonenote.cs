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

    public partial class Microsoftgraphonenote
    {
        /// <summary>
        /// Initializes a new instance of the Microsoftgraphonenote class.
        /// </summary>
        public Microsoftgraphonenote()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Microsoftgraphonenote class.
        /// </summary>
        public Microsoftgraphonenote(string id = default(string), IList<Microsoftgraphnotebook> notebooks = default(IList<Microsoftgraphnotebook>), IList<MicrosoftgraphonenoteSection> sections = default(IList<MicrosoftgraphonenoteSection>), IList<MicrosoftgraphsectionGroup> sectionGroups = default(IList<MicrosoftgraphsectionGroup>), IList<MicrosoftgraphonenotePage> pages = default(IList<MicrosoftgraphonenotePage>), IList<MicrosoftgraphonenoteResource> resources = default(IList<MicrosoftgraphonenoteResource>), IList<MicrosoftgraphonenoteOperation> operations = default(IList<MicrosoftgraphonenoteOperation>))
        {
            Id = id;
            Notebooks = notebooks;
            Sections = sections;
            SectionGroups = sectionGroups;
            Pages = pages;
            Resources = resources;
            Operations = operations;
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
        [JsonProperty(PropertyName = "notebooks")]
        public IList<Microsoftgraphnotebook> Notebooks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sections")]
        public IList<MicrosoftgraphonenoteSection> Sections { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sectionGroups")]
        public IList<MicrosoftgraphsectionGroup> SectionGroups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pages")]
        public IList<MicrosoftgraphonenotePage> Pages { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<MicrosoftgraphonenoteResource> Resources { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operations")]
        public IList<MicrosoftgraphonenoteOperation> Operations { get; set; }

    }
}