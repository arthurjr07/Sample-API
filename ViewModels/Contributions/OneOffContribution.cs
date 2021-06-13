// <copyright file="OneOffContribution.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Contributions
{
    /// <summary>
    /// Model for one-off contributions.
    /// </summary>
    public class OneOffContribution
    {
        /// <summary>
        /// Gets the bond year.
        /// </summary>
        public int BondYear { get; }

        /// <summary>
        /// Gets the amount.
        /// </summary>
        public double Amount { get; }
    }
}
