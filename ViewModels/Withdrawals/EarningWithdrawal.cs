// <copyright file="EarningWithdrawal.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Withdrawals
{
    /// <summary>
    /// Model for an earning withdrawal input.
    /// </summary>
    public class EarningWithdrawal
    {
        /// <summary>
        /// Gets the bond year for this withdrawal.
        /// </summary>
        public int BondYear { get; }

        /// <summary>
        /// Gets the value of the withdrawal.
        /// </summary>
        public double WithdrawalValue { get; }
    }
}
