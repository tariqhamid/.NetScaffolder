﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TitleCaseNamingConventionUnitTest.cs" company="">
//   
// </copyright>
// <summary>
//   The title case naming convention unit test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeGenerator.Test.Components.NamingConventions
{
    #region Using

    using Contractors.NamingConventions.DefaultNamingConventions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    /// Tests TitleCaseNamingConvention
    /// </summary>
    [TestClass]
    public class TitleCaseNamingConventionUnitTest
    {
        #region Public methods and operators

        /// <summary>
        /// Tests ApplyNamingConvention
        /// </summary>
        [TestMethod]
        public void TitleCaseNamingConventionUnitTest_ApplyNamingConvention()
        {
            TitleCaseNamingConvention namingConvention = new TitleCaseNamingConvention();
            Assert.AreEqual(
                "Title Case",
                namingConvention.ApplyNamingConvention("title case"),
                "The result should be TitleCase");

            Assert.AreEqual(
                "TitleCase",
                namingConvention.ApplyNamingConvention("titlecase"),
                "The result should be TitleCase");
        }

        #endregion
    }
}