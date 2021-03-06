﻿namespace DotNetScaffolder.Presentation.Forms.Controls
{
    partial class PackageDetailsUserControl
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckBoxEnabled = new System.Windows.Forms.CheckBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.PanelTemplate = new System.Windows.Forms.Panel();
            this.Templates = new System.Windows.Forms.GroupBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ComboBoxSearch = new System.Windows.Forms.ComboBox();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.TemplateListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.PanelTemplate.SuspendLayout();
            this.Templates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckBoxEnabled);
            this.panel1.Controls.Add(this.TextBoxName);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 66);
            this.panel1.TabIndex = 59;
            // 
            // CheckBoxEnabled
            // 
            this.CheckBoxEnabled.AutoSize = true;
            this.CheckBoxEnabled.Location = new System.Drawing.Point(172, 40);
            this.CheckBoxEnabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckBoxEnabled.Name = "CheckBoxEnabled";
            this.CheckBoxEnabled.Size = new System.Drawing.Size(94, 24);
            this.CheckBoxEnabled.TabIndex = 61;
            this.CheckBoxEnabled.Text = "Enabled";
            this.CheckBoxEnabled.UseVisualStyleBackColor = true;
            this.CheckBoxEnabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(172, 0);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(355, 26);
            this.TextBoxName.TabIndex = 54;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(99, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 53;
            this.label13.Text = "Name:";
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(560, -3);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(112, 35);
            this.button11.TabIndex = 62;
            this.button11.Text = "Default";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // PanelTemplate
            // 
            this.PanelTemplate.Controls.Add(this.Templates);
            this.PanelTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTemplate.Location = new System.Drawing.Point(0, 66);
            this.PanelTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelTemplate.Name = "PanelTemplate";
            this.PanelTemplate.Size = new System.Drawing.Size(676, 502);
            this.PanelTemplate.TabIndex = 60;
            // 
            // Templates
            // 
            this.Templates.Controls.Add(this.BtnAdd);
            this.Templates.Controls.Add(this.ComboBoxSearch);
            this.Templates.Controls.Add(this.BtnRemove);
            this.Templates.Controls.Add(this.TemplateListBox);
            this.Templates.Controls.Add(this.label1);
            this.Templates.Location = new System.Drawing.Point(0, 5);
            this.Templates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Templates.Name = "Templates";
            this.Templates.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Templates.Size = new System.Drawing.Size(668, 492);
            this.Templates.TabIndex = 1;
            this.Templates.TabStop = false;
            this.Templates.Text = "Template";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(519, 45);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(112, 35);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ComboBoxSearch
            // 
            this.ComboBoxSearch.FormattingEnabled = true;
            this.ComboBoxSearch.Location = new System.Drawing.Point(84, 45);
            this.ComboBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxSearch.Name = "ComboBoxSearch";
            this.ComboBoxSearch.Size = new System.Drawing.Size(414, 28);
            this.ComboBoxSearch.TabIndex = 4;
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(519, 434);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(112, 35);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // TemplateListBox
            // 
            this.TemplateListBox.FormattingEnabled = true;
            this.TemplateListBox.ItemHeight = 20;
            this.TemplateListBox.Location = new System.Drawing.Point(14, 98);
            this.TemplateListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TemplateListBox.Name = "TemplateListBox";
            this.TemplateListBox.Size = new System.Drawing.Size(643, 324);
            this.TemplateListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PackageDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTemplate);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PackageDetailsUserControl";
            this.Size = new System.Drawing.Size(676, 568);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelTemplate.ResumeLayout(false);
            this.Templates.ResumeLayout(false);
            this.Templates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelTemplate;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox CheckBoxEnabled;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox Templates;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.ListBox TemplateListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox ComboBoxSearch;
    }
}
