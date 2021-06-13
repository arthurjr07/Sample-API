// <copyright file="PreTenYearWithdrawal.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Withdrawals
{
    /// <summary>
    /// Model for a ten year withdrawal input.
    /// </summary>
    public class PreTenYearWithdrawal
    {
        /// <summary>
        /// Gets the bond year.
        /// </summary>
        public int BondYear { get; }

        /// <summary>
        /// Gets the value of the withdrawal.
        /// </summary>
        public double WithdrawalValue { get; }
    }
}
