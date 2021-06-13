// <copyright file="InvestmentOption.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Allocations
{
    /// <summary>
    /// Model for an investment option input.
    /// </summary>
    public class InvestmentOption
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvestmentOption"/> class.
        /// </summary>
        /// <param name="name">The name of the investment option.</param>
        /// <param name="percentValue">The percentage value of the investment option.</param>
        public InvestmentOption(string name, double percentValue)
        {
            this.Name = name;
            this.PercentValue = percentValue;
        }

        /// <summary>
        /// Gets the full name value of the option from the workbook.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the percentage value of the investment option.
        /// </summary>
        public double PercentValue { get; }
    }
}
