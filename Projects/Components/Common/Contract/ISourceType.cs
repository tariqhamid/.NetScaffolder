﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISourceType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract
{
    #region Usings

    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    ///     The SourceType interface.
    ///     This is the source from which the data structure is imported.
    /// </summary>
    /// <example>Edmx, Sql Database, Data Modeller</example>
    public interface ISourceType
    {
        #region Public Methods And Operators

        /// <summary>
        /// The add config ui.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        object AddConfigUI(object parameters);

        /// <summary>
        /// The import.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        DatabaseModel Import(object options);

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        object Load(object parameters);

        /// <summary>
        /// Map database type to c# type.
        /// </summary>
        /// <param name="databaseType">
        /// The database type.
        /// </param>
        /// <returns>
        /// The <see cref="DomainDataType"/>.
        /// </returns>
        DomainDataType MapDatabaseTypeToCSharp(string databaseType);

        /// <summary>
        /// Save parameters
        /// </summary>
        /// <param name="parameters">
        /// </param>
        void Save(object parameters);

        /// <summary>
        /// Test DataSource
        /// </summary>
        /// <param name="parameters">
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool Test(object parameters);

        #endregion
    }
}