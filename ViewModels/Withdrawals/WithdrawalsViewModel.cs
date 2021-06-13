// <copyright file="WithdrawalsViewModel.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Withdrawals
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Model for the withdrawal inputs.
    /// </summary>
    public class WithdrawalsViewModel
    {
        /// <summary>
        /// Gets the education claim inputs.
        /// </summary>
        public IEnumerable<EducationClaim> EducationClaims { get; }

        /// <summary>
        /// Gets the list of capital withdrawal inputs.
        /// </summary>
        public IEnumerable<CapitalWithdrawal> CapitalWithdrawals { get; }

        /// <summary>
        /// Gets the list of earning withdrawal inputs.
        /// </summary>
        public IEnumerable<EarningWithdrawal> EarningWithdrawals { get; }

        /// <summary>
        /// Gets the list of pre-ten year withdrawal inputs.
        /// </summary>
        public IEnumerable<PreTenYearWithdrawal> PreTenYearWithdrawals { get; }
    }
}
