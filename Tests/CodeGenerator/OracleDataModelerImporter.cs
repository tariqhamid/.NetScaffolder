﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OracleDataModelerImporter.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Test
{
    #region Usings

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The oracle data modeler importer tests.
    /// </summary>
    [TestClass]
    public class OracleDataModelerImporter
    {
        #region Public Methods And Operators

        /// <summary>
        ///     The load from oracle modeller.
        /// </summary>
        [TestMethod]
        public void LoadOracleModeller()
        {
            // var dataSource = new DmdMetadataSource();
            // string filePAth = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\DataSource\nFrallApps.dmd");
            // MetadataTableCollection data = dataSource.LoadSource(filePAth);
            // Assert.AreEqual(44, data.Tables.Count, "Nine tables were expected");
            // Assert.IsNotNull(
            // data.Tables.First(t => t.TableName == "Application"), 
            // "The Application table does not exist");
            // Assert.AreEqual(
            // 4, 
            // data.Tables.First(t => t.TableName == "Application").Columns.Count, 
            // "Application should have 5 columns");
            // Assert.AreEqual(
            // 0, 
            // data.Tables.First(t => t.TableName == "Application").RelationShips.Count, 
            // "Application should have 0 relationships");
        }

        #endregion
    }
}