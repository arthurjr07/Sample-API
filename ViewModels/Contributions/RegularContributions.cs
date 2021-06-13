// <copyright file="RegularContributions.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Contributions
{
    /// <summary>
    /// Model for the regular contribution inputs.
    /// </summary>
    public class RegularContributions
    {
        /// <summary>
        /// Gets the frequency of the contribution.
        /// </summary>
        public string Frequency { get; }

        /// <summary>
        /// Gets the amount of the regular contribution.
        /// </summary>
        public double Amount { get; }

        /// <summary>
        /// Gets a value indicating whether the contribution increases every year.
        /// </summary>
        public bool IncreaseContributionPerYear { get; }

        /// <summary>
        /// Gets the annual increase percentage.
        /// </summary>
        public int AnnualIncrease { get; }

        /// <summary>
        /// Gets a value indicating whether the contribution will only apply part of the term.
        /// </summary>
        public bool ApplyContributionToPartTerm { get; }

        /// <summary>
        /// Gets the contribution term start year.
        /// </summary>
        public int ContributionTermStart { get; }

        /// <summary>
        /// Gets the contribution term end year.
        /// </summary>
        public int ContributionTermEnd { get; }
    }
}
