// <copyright file="EducationClaim.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Withdrawals
{
    using System;

    /// <summary>
    /// Model for an education claim input.
    /// </summary>
    public class EducationClaim
    {
        /// <summary>
        /// Gets the beneficiary id.
        /// </summary>
        public Guid BeneficiaryId { get; }

        /// <summary>
        /// Gets the bond year for this claim.
        /// </summary>
        public int BondYear { get; }

        /// <summary>
        /// Gets the value of the claim.
        /// </summary>
        public double ClaimValue { get; }
    }
}
