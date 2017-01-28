﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TitleCaseNoUnderScoreNamingConvention.cs" company="">
//   
// </copyright>
// <summary>
//   The title case no under score naming convention.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Contractors.NamingConventions.DefaultNamingConventions
{
    #region Using

    using System;
    using System.ComponentModel.Composition;
    using System.Threading;

    using Components.Common.Contract;

    #endregion

    /// <summary>
    /// The title case no under score naming convention.
    /// </summary>
    [Export(typeof(INamingConvention))]
    [ExportMetadata("NameMetaData", "TitleCaseNoUnderScore")]
    public class TitleCaseNoUnderScoreNamingConvention : INamingConvention
    {
        #region Public methods and operators

        /// <summary>
        /// Apply the naming convention.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public string ApplyNamingConvention(string value)
        {
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(value.ToLower()).Replace("_", string.Empty);
        }

        #endregion
    }
}