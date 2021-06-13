// <copyright file="BeneficiariesViewModel.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Beneficiaries
{
    using System.Collections.Generic;

    /// <summary>
    /// View model for beneficiaries form inputs.
    /// </summary>
    public class BeneficiariesViewModel
    {
        /// <summary>
        /// Gets the list of beneficiaries.
        /// </summary>
        public IEnumerable<Beneficiary> Beneficiaries { get; }
    }
}
