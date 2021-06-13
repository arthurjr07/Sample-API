// <copyright file="InitialContribution.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Contributions
{
    /// <summary>
    /// Model for the intial contribution inputs.
    /// </summary>
    public class InitialContribution
    {
        /// <summary>
        /// Gets the initial contribution value.
        /// </summary>
        public double ContributionValue { get; }

        /// <summary>
        /// Gets a value indicating whether the initial contributions.
        /// </summary>
        public bool IsTestamentaryBenefit { get; }

        /// <summary>
        /// Gets the expected bond year for the testamentary benefit.
        /// </summary>
        public int ExpectedBondYear { get; }
    }
}
