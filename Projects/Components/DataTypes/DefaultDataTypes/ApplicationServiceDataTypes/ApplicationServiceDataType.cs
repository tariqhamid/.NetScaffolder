﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;
using FormControls.TreeView;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
{
    using System.IO;
    using System.Xml;

    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Model;
    using DotNetScaffolder.Mapping.MetaData.Project;

    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Application Service")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4420")]

    public class ApplicationServiceDataType : IDataType
    {
        public string Namespace { get; set; } = "ApplicationService";

        public string OutputFolder { get; set; } = "Application Service";

        public bool Enabled { get; set; } = false;

        private const string FILE_NAME = "ApplicationService.mdl";

        public ApplicationServiceDataType()
        {
            
        }

        public IHierarchy ReturnNavigation()
        {
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4420"), Name = "Application Service" };
        }

        public IDataTypeUI<IDictionary<string, string>, DT> AddConfigUI<DT>(object parameters)
        {
            return null;
        }

        public bool SaveConfig(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);
            ObjectXMLSerializer<ApplicationServiceDataType>.Save(this, filePath);
            return true;
        }

        public void LoadConfig(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);

            if (File.Exists(filePath))
            {
                var appService = ObjectXMLSerializer<ApplicationServiceDataType>.Load(filePath);
                if (appService != null)
                {
                }
            }
        }

        public Table MetaData { get; set; }
    }
}
