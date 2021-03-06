﻿namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes
{
    partial class ApplicationServiceUserControl
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
            this.AppServiceEnabled = new System.Windows.Forms.CheckBox();
            this.AppServiceOutputFolder = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.AppServiceNamespace = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppServiceEnabled
            // 
            this.AppServiceEnabled.AutoSize = true;
            this.AppServiceEnabled.Location = new System.Drawing.Point(106, 60);
            this.AppServiceEnabled.Name = "AppServiceEnabled";
            this.AppServiceEnabled.Size = new System.Drawing.Size(65, 17);
            this.AppServiceEnabled.TabIndex = 63;
            this.AppServiceEnabled.Text = "Enabled";
            this.AppServiceEnabled.UseVisualStyleBackColor = true;
            // 
            // AppServiceOutputFolder
            // 
            this.AppServiceOutputFolder.Location = new System.Drawing.Point(106, 34);
            this.AppServiceOutputFolder.Name = "AppServiceOutputFolder";
            this.AppServiceOutputFolder.Size = new System.Drawing.Size(121, 20);
            this.AppServiceOutputFolder.TabIndex = 62;
            this.AppServiceOutputFolder.Text = "UnitOfWork";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(12, 38);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(74, 13);
            this.label34.TabIndex = 61;
            this.label34.Text = "Output Folder:";
            // 
            // AppServiceNamespace
            // 
            this.AppServiceNamespace.Location = new System.Drawing.Point(106, 8);
            this.AppServiceNamespace.Name = "AppServiceNamespace";
            this.AppServiceNamespace.Size = new System.Drawing.Size(121, 20);
            this.AppServiceNamespace.TabIndex = 60;
            this.AppServiceNamespace.Text = "UnitOfWork";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(19, 12);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(67, 13);
            this.label35.TabIndex = 59;
            this.label35.Text = "Namespace:";
            // 
            // ApplicationServiceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AppServiceEnabled);
            this.Controls.Add(this.AppServiceOutputFolder);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.AppServiceNamespace);
            this.Controls.Add(this.label35);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ApplicationServiceUserControl";
            this.Size = new System.Drawing.Size(273, 112);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        public System.Windows.Forms.CheckBox AppServiceEnabled;
        public System.Windows.Forms.TextBox AppServiceOutputFolder;
        public System.Windows.Forms.TextBox AppServiceNamespace;
    }
}
