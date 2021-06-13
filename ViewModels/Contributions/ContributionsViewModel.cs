// <copyright file="ContributionsViewModel.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Contributions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Model for the contribution inputs.
    /// </summary>
    public class ContributionsViewModel
    {
        /// <summary>
        /// Getst the general inputs.
        /// </summary>
        public GeneralInput GeneralInput { get; }

        /// <summary>
        /// Gets the intitial contribution inputs.
        /// </summary>
        public InitialContribution InitialContribution { get; }

        /// <summary>
        /// Gets a value indicating whether the regular contributions are included.
        /// </summary>
        public bool IncludeRegularContributions { get; }

        /// <summary>
        /// Gets the regular contribution inputs.
        /// </summary>
        public RegularContributions RegularContributions { get; }

        /// <summary>
        /// Gets a value indicating whether one-off contributions are included.
        /// </summary>
        public bool IncludeOneOffContributions { get; }

        /// <summary>
        /// Gets the list of one-off contributions.
        /// </summary>
        public IEnumerable<OneOffContribution> OneOffContributions { get; }
    }
}
