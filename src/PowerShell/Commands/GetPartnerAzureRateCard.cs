﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.PowerShell.Commands
{
    using System.Management.Automation;
    using Models.Authentication;
    using Models.RateCards;
    using PartnerCenter.Models.RateCards;

    /// <summary>
    /// Cmdlet that retrieves Azrue Rate Card details.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "PartnerAzureRateCard")]
    [OutputType(typeof(PSAzureRateCard))]
    public class GetPartnerAzureRateCard : PartnerAsyncCmdlet
    {
        /// <summary>
        /// Gets or sets the identifier of the customer.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "An optional three letter ISO code for the currency in which the resource rates will be provided.")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the offer category.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "An optional two-letter ISO country/region code that indicates the market where the offer is purchased.")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating whether or not to retrieve the Azure Rate Card for Azure Partner Shared Services (APSS).
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Flag indicating whether or not to retrieve the Azure Rate Card for Azure Partner Shared Services (APSS).")]
        public SwitchParameter SharedServices { get; set; }

        /// <summary>
        /// Executes the operations associated with the cmdlet.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            Scheduler.RunTask(async () =>
            {
                IPartner partner = await PartnerSession.Instance.ClientFactory.CreatePartnerOperationsAsync(CorrelationId, CancellationToken).ConfigureAwait(false);
                AzureRateCard rateCard;

                if (SharedServices.IsPresent && SharedServices.ToBool())
                {
                    rateCard = await partner.RateCards.Azure.GetSharedAsync(Currency, Region, CancellationToken).ConfigureAwait(false);
                }
                else
                {
                    rateCard = await partner.RateCards.Azure.GetAsync(Currency, Region, CancellationToken).ConfigureAwait(false);
                }

                WriteObject(new PSAzureRateCard(rateCard));
            }, true);
        }
    }
}