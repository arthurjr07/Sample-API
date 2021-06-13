// <copyright file="GeneralInput.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels
{
    using System;

    /// <summary>
    /// View model for the general inputs.
    /// </summary>
    public class GeneralInput
    {
        /// <summary>
        /// Gets the calculation reference input value.
        /// </summary>
        public string CalculationReference { get; }

        /// <summary>
        /// Gets the investment term input value.
        /// </summary>
        public int InvestmentTerm { get; }

        /// <summary>
        /// Gets the marginal tax rate.
        /// </summary>
        public double MarginalTaxRate { get; }
    }
}
