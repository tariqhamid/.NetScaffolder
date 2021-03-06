﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScaffoldConfig.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Configuration
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Linq;

    using DotNetScaffolder.Components.Common;
    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    ///     The scaffold config.
    /// </summary>
    public class ScaffoldConfig
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes static members of the <see cref="ScaffoldConfig" /> class.
        ///     Initializes a new instance of the <see cref="ScaffoldConfig" /> class.
        /// </summary>
        static ScaffoldConfig()
        {
            LanguageOutputs = new Lazy<ILanguageOutput, IDictionary<string, object>>[0];
            OutputGenerators = new Lazy<IOutputGenerator, IDictionary<string, object>>[0];
            SourceTypes = new Lazy<ISourceType, IDictionary<string, object>>[0];
            NamingConventions = new Lazy<INamingConvention, IDictionary<string, object>>[0];
            Drivers = new Lazy<IDriver, IDictionary<string, object>>[0];
            ModelPath = @"..\..\..\..\..\Generated\Dal\Repository\EF\Dotnet\RepositoryEFDotnet\Model\Banking.mdl";
            ConfigPath = @"Config\Settings.xml";
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the collection options.
        /// </summary>
        [ImportMany]
        public static Lazy<ICollectionOption, IDictionary<string, object>>[] CollectionOptions { get; set; }

        /// <summary>
        /// Gets or sets the config path.
        /// </summary>
        public static string ConfigPath { get; set; }

        /// <summary>
        ///     Gets or sets the DataTypes
        /// </summary>
        [ImportMany]
        public static Lazy<IDataType, IDictionary<string, object>>[] DataTypes { get; set; }

        /// <summary>
        ///     Gets or sets the drivers.
        /// </summary>
        [ImportMany]
        public static Lazy<IDriver, IDictionary<string, object>>[] Drivers { get; set; }

        /// <summary>
        ///     Gets or sets the language outputs.
        /// </summary>
        [ImportMany]
        public static Lazy<ILanguageOutput, IDictionary<string, object>>[] LanguageOutputs { get; set; }

        /// <summary>
        /// Gets or sets the model path.
        /// </summary>
        public static string ModelPath { get; set; }

        /// <summary>
        ///     Gets or sets the naming conventions.
        /// </summary>
        [ImportMany]
        public static Lazy<INamingConvention, IDictionary<string, object>>[] NamingConventions { get; set; }

        /// <summary>
        ///     Gets or sets the output generators.
        /// </summary>
        [ImportMany]
        public static Lazy<IOutputGenerator, IDictionary<string, object>>[] OutputGenerators { get; set; }

        /// <summary>
        ///     Gets or sets the source types.
        /// </summary>
        [ImportMany]
        public static Lazy<ISourceType, IDictionary<string, object>>[] SourceTypes { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     The load.
        /// </summary>
        public static void Load()
        {
            ComponentImporter importer = new ComponentImporter();
            importer.Import();

            Drivers = importer.Drivers;
            NamingConventions = importer.NamingConventions;
            SourceTypes = importer.SourceTypes;
            LanguageOutputs = importer.LanguageOutputs;
            OutputGenerators = importer.OutputGenerators;
            DataTypes = importer.DataTypes;
            CollectionOptions = importer.CollectionOptions;
        }

        /// <summary>
        /// The return data type.
        /// </summary>
        /// <param name="dataTypeId">
        /// The data type id.
        /// </param>
        /// <returns>
        /// The <see cref="IDataType"/>.
        /// </returns>
        public static IDataType ReturnDataType(Guid dataTypeId)
        {
            return DataTypes.FirstOrDefault(
                d => d.Metadata["ValueMetaData"].ToString().ToLower() == dataTypeId.ToString().ToLower()).Value;
        }

        /// <summary>
        /// The return source type.
        /// </summary>
        /// <param name="sourceTypeId">
        /// The source type id.
        /// </param>
        /// <returns>
        /// The <see cref="ISourceType"/>.
        /// </returns>
        public static ISourceType ReturnSourceType(Guid sourceTypeId)
        {
            return SourceTypes.FirstOrDefault(
                d => d.Metadata["ValueMetaData"].ToString().ToLower() == sourceTypeId.ToString().ToLower()).Value;
        }

        #endregion
    }
}