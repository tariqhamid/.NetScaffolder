﻿namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ContextDataTypes
{
    partial class ContextUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContextEnabled = new System.Windows.Forms.CheckBox();
            this.LoggingEnabled = new System.Windows.Forms.CheckBox();
            this.InheritFromInterface = new System.Windows.Forms.TextBox();
            this.ConstructionOptions = new System.Windows.Forms.ComboBox();
            this.OutputFolder = new System.Windows.Forms.TextBox();
            this.Namespace = new System.Windows.Forms.TextBox();
            this.ContextName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.GenerateInterface = new System.Windows.Forms.CheckBox();
            this.CreateDb = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.OutputPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextEnabled
            // 
            this.ContextEnabled.AutoSize = true;
            this.ContextEnabled.Location = new System.Drawing.Point(272, 90);
            this.ContextEnabled.Name = "ContextEnabled";
            this.ContextEnabled.Size = new System.Drawing.Size(65, 17);
            this.ContextEnabled.TabIndex = 56;
            this.ContextEnabled.Text = "Enabled";
            this.ContextEnabled.UseVisualStyleBackColor = true;
            // 
            // LoggingEnabled
            // 
            this.LoggingEnabled.AutoSize = true;
            this.LoggingEnabled.Location = new System.Drawing.Point(272, 67);
            this.LoggingEnabled.Name = "LoggingEnabled";
            this.LoggingEnabled.Size = new System.Drawing.Size(106, 17);
            this.LoggingEnabled.TabIndex = 55;
            this.LoggingEnabled.Text = "Logging Enabled";
            this.LoggingEnabled.UseVisualStyleBackColor = true;
            // 
            // InheritFromInterface
            // 
            this.InheritFromInterface.Location = new System.Drawing.Point(121, 129);
            this.InheritFromInterface.Name = "InheritFromInterface";
            this.InheritFromInterface.Size = new System.Drawing.Size(121, 20);
            this.InheritFromInterface.TabIndex = 54;
            // 
            // ConstructionOptions
            // 
            this.ConstructionOptions.FormattingEnabled = true;
            this.ConstructionOptions.Items.AddRange(new object[] {
            "None",
            "Single",
            "Extral"});
            this.ConstructionOptions.Location = new System.Drawing.Point(121, 102);
            this.ConstructionOptions.Name = "ConstructionOptions";
            this.ConstructionOptions.Size = new System.Drawing.Size(121, 21);
            this.ConstructionOptions.TabIndex = 53;
            // 
            // OutputFolder
            // 
            this.OutputFolder.Location = new System.Drawing.Point(121, 74);
            this.OutputFolder.Name = "OutputFolder";
            this.OutputFolder.Size = new System.Drawing.Size(121, 20);
            this.OutputFolder.TabIndex = 52;
            this.OutputFolder.Text = "Context";
            // 
            // Namespace
            // 
            this.Namespace.Location = new System.Drawing.Point(121, 45);
            this.Namespace.Name = "Namespace";
            this.Namespace.Size = new System.Drawing.Size(121, 20);
            this.Namespace.TabIndex = 51;
            this.Namespace.Text = "Context";
            // 
            // ContextName
            // 
            this.ContextName.Location = new System.Drawing.Point(121, 19);
            this.ContextName.Name = "ContextName";
            this.ContextName.Size = new System.Drawing.Size(121, 20);
            this.ContextName.TabIndex = 50;
            this.ContextName.Text = "Security Model";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 127);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(110, 13);
            this.label27.TabIndex = 49;
            this.label27.Text = "Inherit From Interface:";
            // 
            // GenerateInterface
            // 
            this.GenerateInterface.AutoSize = true;
            this.GenerateInterface.Location = new System.Drawing.Point(272, 44);
            this.GenerateInterface.Name = "GenerateInterface";
            this.GenerateInterface.Size = new System.Drawing.Size(115, 17);
            this.GenerateInterface.TabIndex = 48;
            this.GenerateInterface.Text = "Generate Interface";
            this.GenerateInterface.UseVisualStyleBackColor = true;
            // 
            // CreateDb
            // 
            this.CreateDb.AutoSize = true;
            this.CreateDb.Location = new System.Drawing.Point(272, 21);
            this.CreateDb.Name = "CreateDb";
            this.CreateDb.Size = new System.Drawing.Size(184, 17);
            this.CreateDb.TabIndex = 47;
            this.CreateDb.Text = "Create Database If it doesn\'t exist";
            this.CreateDb.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 102);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(108, 13);
            this.label26.TabIndex = 46;
            this.label26.Text = "Construction Options:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(46, 74);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 13);
            this.label25.TabIndex = 45;
            this.label25.Text = "Output Folder:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(46, 47);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 13);
            this.label24.TabIndex = 44;
            this.label24.Text = "NameSpace:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(38, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "Context Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OutputPath);
            this.groupBox1.Controls.Add(this.OutputFolder);
            this.groupBox1.Controls.Add(this.ContextEnabled);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.LoggingEnabled);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.InheritFromInterface);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.ConstructionOptions);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.CreateDb);
            this.groupBox1.Controls.Add(this.Namespace);
            this.groupBox1.Controls.Add(this.GenerateInterface);
            this.groupBox1.Controls.Add(this.ContextName);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 180);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Context settings";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(437, 189);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 58;
            this.btnNew.Text = "Add";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // OutputPath
            // 
            this.OutputPath.Location = new System.Drawing.Point(121, 154);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(304, 20);
            this.OutputPath.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Output Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(434, 152);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 59;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ContextUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ContextUserControl";
            this.Size = new System.Drawing.Size(515, 215);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ContextEnabled;
        private System.Windows.Forms.CheckBox LoggingEnabled;
        private System.Windows.Forms.TextBox InheritFromInterface;
        private System.Windows.Forms.ComboBox ConstructionOptions;
        private System.Windows.Forms.TextBox OutputFolder;
        private System.Windows.Forms.TextBox Namespace;
        private System.Windows.Forms.TextBox ContextName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox GenerateInterface;
        private System.Windows.Forms.CheckBox CreateDb;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox OutputPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
    }
}
