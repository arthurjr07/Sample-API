// <copyright file="Fee.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Allocations
{
    /// <summary>
    /// Model for fee type inputs.
    /// </summary>
    public class Fee
    {
        /// <summary>
        /// Gets the fixed fee value.
        /// </summary>
        public double Fixed { get; }

        /// <summary>
        /// Gets the percentage fee value.
        /// </summary>
        public double Percentage { get; }
    }
}
