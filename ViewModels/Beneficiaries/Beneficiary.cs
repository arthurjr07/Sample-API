// <copyright file="Beneficiary.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.WebAPI.ViewModels.Beneficiaries
{
    using System;

    /// <summary>
    /// Model for a beneficiary input.
    /// </summary>
    public class Beneficiary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Beneficiary"/> class.
        /// </summary>
        /// <param name="formId">The form id this beneficiary is related to.</param>
        /// <param name="name">The name of the beneficiary.</param>
        /// <param name="age">The age of the beneficiary.</param>
        /// <param name="otherTaxableIncome">Other taxable income amount, if any.</param>
        public Beneficiary(Guid formId, string name, int age, double? otherTaxableIncome)
        {
            this.FormId = formId;
            this.Name = name;
            this.Age = age;
            this.OtherTaxableIncome = otherTaxableIncome;
        }

        /// <summary>
        /// Gets the calculator form id this beneficiary is related to.
        /// </summary>
        public Guid FormId { get; }

        /// <summary>
        /// Gets the beneficiary's id.
        /// </summary>
        public Guid BeneficiaryId { get; }

        /// <summary>
        /// Gets the beneficiary name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the beneficiary age.
        /// </summary>
        public int Age { get; }

        /// <summary>
        /// Gets a beneficiarie's other taxable income.
        /// </summary>
        public double? OtherTaxableIncome { get; }
    }
}
