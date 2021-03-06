﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DomainDefinition.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Domain
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    using Common.Logging;

    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Model;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    #endregion

    /// <summary>
    ///     The domain definition. Domains are used to group
    ///     tables together. i.e) Security
    /// </summary>
    public class DomainDefinition : IValidate
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DomainDefinition" /> class.
        /// </summary>
        public DomainDefinition()
        {
            Tables = new List<Table>();
            Package = new Package();
            Id = Guid.NewGuid();
            ValidationResult = new List<Validation>();
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the collection option. At the moment this specifies the collection parent but could be extended at a
        ///     later stage.
        /// </summary>
        public Guid CollectionOptionId { get; set; }

        /// <summary>
        ///     Gets or sets the driver id.
        /// </summary>
        /// <example>
        ///     Entity Framework
        /// </example>
        public Guid DriverId { get; set; }

        /// <summary>
        ///     Gets or sets the driver id.
        /// </summary>
        /// <example>
        ///     Oracle Drivers
        /// </example>
        public Guid DriverTypeId { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the name of the domain.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the naming convention Id.
        /// </summary>
        public Guid NamingConventionId { get; set; }

        /// <summary>
        ///     Gets or sets the package.
        /// </summary>
        public Package Package { get; set; }

        /// <summary>
        ///     Gets or sets the source type. This specifies if it should be loaded from an edmx file,
        ///     sql metadata, etc.
        /// </summary>
        public Guid SourceTypeId { get; set; }

        /// <summary>
        ///     Gets or sets the tables belonging to the domain
        /// </summary>
        public List<Table> Tables { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        ///     Validate class.
        /// </summary>
        /// <returns>
        ///     The <see cref="List{T}" />
        ///     Errors returned
        /// </returns>
        public List<Validation> Validate()
        {
            Logger.Trace("Started Validate()");

            ValidationResult.Clear();

            if (string.IsNullOrEmpty(Name))
            {
                ValidationResult.Add(new Validation(ValidationType.DomainName, "Name cannot be empty"));
            }

            if (Id == Guid.Empty)
            {
                ValidationResult.Add(new Validation(ValidationType.DomainId, "Id cannot be empty"));
            }

            if (NamingConventionId == Guid.Empty)
            {
                ValidationResult.Add(new Validation(ValidationType.NamingConventionId, "NamingConventionId cannot be empty"));
            }

            if (SourceTypeId == Guid.Empty)
            {
                ValidationResult.Add(new Validation(ValidationType.SourceTypeId, "SourceTypeId cannot be empty"));
            }

            if (DriverId == Guid.Empty)
            {
                ValidationResult.Add(new Validation(ValidationType.DriverId, "DriverId cannot be empty"));
            }

            if (DriverTypeId == Guid.Empty)
            {
                ValidationResult.Add(new Validation(ValidationType.DriverTypeId, "DriverTypeId cannot be empty"));
            }

            if (CollectionOptionId == Guid.Empty)
            {
                ValidationResult.Add(new Validation(ValidationType.CollectionOptionId, "CollectionOptionId cannot be empty"));
            }

            Logger.Debug($"Number of Validation errors: {ValidationResult.Count}");
            Logger.Trace($"Validation errors: {ValidationResult}");
            Logger.Trace("Completed Validate()");
            return ValidationResult;
        }

        #endregion
    }
}