﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDefinitionApplicationServiceFile.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.ApplicationServices
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;

    using Common.Logging;

    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Project;

    #endregion

    /// <summary>
    ///     The file project definition.
    /// </summary>
    public class ProjectDefinitionApplicationServiceFile : IProjectDefinitionApplicationService
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ProjectDefinitionApplicationServiceFile" /> class.
        /// </summary>
        public ProjectDefinitionApplicationServiceFile()
        {
            Logger.Trace($"Started ProjectDefinitionApplicationServiceFile()");
            ProjectDefinition = new ProjectDefinition();
            FilePersistenceOptions = new FilePersistenceOptions();
            Logger.Trace($"Completed ProjectDefinitionApplicationServiceFile()");
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the file persistence options.
        /// </summary>
        public FilePersistenceOptions FilePersistenceOptions { get; set; }

        /// <summary>
        ///     Gets or sets the project definition.
        /// </summary>
        public ProjectDefinition ProjectDefinition { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        ///     Load ProjectDefinition.
        /// </summary>
        public void Load()
        {
            Logger.Trace($"Started Load() - Path: {FilePersistenceOptions.Path}");
            ProjectDefinition = ObjectXMLSerializer<ProjectDefinition>.Load(FilePersistenceOptions.Path);
            Logger.Trace($"Completed Load() - Path: {FilePersistenceOptions.Path}");
        }

        /// <summary>
        /// The update lookups.
        /// </summary>
        public void UpdateLookups()
        {
        }

        /// <summary>
        ///     Save ProjectDefinition.
        /// </summary>
        public void Save()
        {
            Logger.Trace($"Started Save() - Path: {FilePersistenceOptions.Path}");

            ValidationResult = ProjectDefinition.Validate();

            if (Validate().Count == 0)
            {
                ObjectXMLSerializer<ProjectDefinition>.Save(
                    ProjectDefinition,
                    FilePersistenceOptions.Path,
                    SerializedFormat.Document);
            }
            else
            {
                Logger.Error($"Validation error: {ValidationResult}");
                throw new ApplicationException($"Validation error: {ValidationResult}");
            }

            Logger.Trace($"Completed Save() - Path: {FilePersistenceOptions.Path}");
        }

        /// <summary>
        ///     The add domain.
        /// </summary>
        /// <returns>
        ///     The <see cref="DomainDefinition" />.
        /// </returns>
        public DomainDefinition AddDomain()
        {
            Logger.Trace($"Started AddDomain()");
            DomainDefinition result = new DomainDefinition();

            int index = 1;

            while (ProjectDefinition.Domains.Exists(d => d.Name == $"Domain{index}"))
            {
                index++;
            }

            result.Name = $"Domain{index}";
            Logger.Trace($"Domain name: {result.Name}");
            ProjectDefinition.Domains.Add(result);
            Logger.Trace($"Completed AddDomain()");

            return result;
        }

        /// <summary>
        /// Delete.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public void Delete(Guid id)
        {
            Logger.Trace($"Started Delete() - id: {id}");

            if (ProjectDefinition.Domains.Exists(d => d.Id == id))
            {
                ProjectDefinition.Domains.Remove(
                    ProjectDefinition.Domains.Where(d => d.Id == id).FirstOrDefault());
            }

            Logger.Trace($"Completed Delete() - id: {id}");
        }

        /// <summary>
        /// Returns the data types as Templates
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        /// <summary>
        /// Validate class.
        /// </summary>
        /// <returns>
        /// The <see cref="List{T}"/>
        ///     Errors returned
        /// </returns>
        public List<Validation> Validate()
        {
            Logger.Trace($"Started Validate()");
            ValidationResult = ProjectDefinition.Validate();
            Logger.Trace($"Completed Validate()");
            return ValidationResult;
        }

        #endregion
    }
}