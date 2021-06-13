// <copyright file="CapitalWithdrawal.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Withdrawals
{
    using System;

    /// <summary>
    /// Model for a capital withdrawal input.
    /// </summary>
    public class CapitalWithdrawal
    {
        /// <summary>
        /// Gets the beneficiary id.
        /// </summary>
        public Guid? BeneficiaryId { get; }

        /// <summary>
        /// Gets the bond year of this withdrawal.
        /// </summary>
        public int BondYear { get; }

        /// <summary>
        /// Gets the value of the withdrawal.
        /// </summary>
        public double WithdrawalValue { get; }
    }
}
