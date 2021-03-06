﻿// -----------------------------------------------------------------------
// <copyright file=GetPartnerOfferAddon.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Store.PartnerCenter.PowerShell.Commands
{
    using System.Linq;
    using System.Management.Automation;
    using Models.Authentication;
    using Models.Offers;
    using PartnerCenter.Models;
    using PartnerCenter.Models.Offers;

    [Cmdlet(VerbsCommon.Get, "PartnerOfferAddon")]
    [OutputType(typeof(PSOffer))]
    public class GetPartnerOfferAddon : PartnerAsyncCmdlet
    {
        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The country code in ISO2 format.")]
        [ValidateNotNullOrEmpty]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the offer identifier.
        /// </summary>

        [Parameter(Mandatory = true, Position = 0, HelpMessage = "The identifier of the offer.")]
        [ValidateNotNullOrEmpty]
        public string OfferId { get; set; }

        /// <summary>
        /// Executes the operations associated with the cmdlet.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            Scheduler.RunTask(async () =>
            {
                IPartner partner = await PartnerSession.Instance.ClientFactory.CreatePartnerOperationsAsync(CorrelationId, CancellationToken).ConfigureAwait(false);
                ResourceCollection<Offer> offers;
                string countryCode = (string.IsNullOrEmpty(CountryCode)) ? PartnerSession.Instance.Context.CountryCode : CountryCode;

                offers = await partner.Offers.ByCountry(countryCode).ById(OfferId).AddOns.GetAsync(CancellationToken).ConfigureAwait(false);

                WriteObject(offers.Items.Select(o => new PSOffer(o)), true);
            }, true);
        }
    }
}