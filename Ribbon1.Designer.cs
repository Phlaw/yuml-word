using System;
using Microsoft.Office.Tools.Ribbon;
namespace WordAddIn1
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();

            
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.classButton = this.Factory.CreateRibbonButton();
            this.usecaseButton = this.Factory.CreateRibbonButton();
            this.activityButton = this.Factory.CreateRibbonButton();
            this.editButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.classButton);
            this.group1.Items.Add(this.usecaseButton);
            this.group1.Items.Add(this.activityButton);
            this.group1.Items.Add(this.editButton);
            this.group1.Label = "yUML.me";
            this.group1.Name = "group1";
            // 
            // classButton
            // 
            this.classButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.classButton.Image = ((System.Drawing.Image)(resources.GetObject("classButton.Image")));
            this.classButton.Label = "Class";
            this.classButton.Name = "classButton";
            this.classButton.ShowImage = true;
            // 
            // usecaseButton
            // 
            this.usecaseButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.usecaseButton.Image = ((System.Drawing.Image)(resources.GetObject("usecaseButton.Image")));
            this.usecaseButton.Label = "Use Case";
            this.usecaseButton.Name = "usecaseButton";
            this.usecaseButton.ShowImage = true;
            // 
            // activityButton
            // 
            this.activityButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.activityButton.Image = ((System.Drawing.Image)(resources.GetObject("activityButton.Image")));
            this.activityButton.Label = "Activity";
            this.activityButton.Name = "activityButton";
            this.activityButton.ShowImage = true;
            // 
            // editButton
            // 
            this.editButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.Label = "Edit";
            this.editButton.Name = "editButton";
            this.editButton.ShowImage = true;
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton classButton;
        internal RibbonButton usecaseButton;
        internal RibbonButton activityButton;
        internal RibbonButton editButton;


        
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
