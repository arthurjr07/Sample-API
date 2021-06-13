// <copyright file="AdviserFees.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Allocations
{
    using System;

    /// <summary>
    /// Model for the adviser fee inputs.
    /// </summary>
    public class AdviserFees
    {
        /// <summary>
        /// Gets the initial advise fee inputs.
        /// </summary>
        public Fee InitialAdviseFee { get; }

        /// <summary>
        /// Gets the ongoing adviser service fee.
        /// </summary>
        public Fee AdviserServiceFee { get; }
    }
}
