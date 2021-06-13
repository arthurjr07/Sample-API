// <copyright file="AllocationsViewModel.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Allocations
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Model for allocations inputs.
    /// </summary>
    public class AllocationsViewModel
    {
        /// <summary>
        /// Gets the list of investment options.
        /// </summary>
        public IEnumerable<InvestmentOption> InvestmentOptions { get; }

        /// <summary>
        /// Gets the adviser return inputs.
        /// </summary>
        public double AdviserEstimatedReturn { get; }

        /// <summary>
        /// Gets the adviser fee inputs.
        /// </summary>
        public AdviserFees AdviserFees { get; }
    }
}
