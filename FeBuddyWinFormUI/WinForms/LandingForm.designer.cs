﻿namespace FeBuddyWinFormUI
{
    partial class LandingForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            this.getparseAiracDataSelection = new System.Windows.Forms.RadioButton();
            this.convertDat2SctSelection = new System.Windows.Forms.RadioButton();
            this.airacLabel = new System.Windows.Forms.Label();
            this.airacCycleGroupBox = new System.Windows.Forms.GroupBox();
            this.landingStartButton = new System.Windows.Forms.Button();
            this.manageFacDataSelector = new System.Windows.Forms.RadioButton();
            this.convertSct2FaaGeoMap = new System.Windows.Forms.RadioButton();
            this.convertFaaGeoMap2SCT = new System.Windows.Forms.RadioButton();
            this.convertSct2KmlSelection = new System.Windows.Forms.RadioButton();
            this.convertKml2SCTSelection = new System.Windows.Forms.RadioButton();
            this.convertDxf2SctSelection = new System.Windows.Forms.RadioButton();
            this.convertSct2DxfSelection = new System.Windows.Forms.RadioButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstructionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoadmapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FAQMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreditsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UninstallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airacCycleGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // getparseAiracDataSelection
            // 
            this.getparseAiracDataSelection.AutoSize = true;
            this.getparseAiracDataSelection.Checked = true;
            this.getparseAiracDataSelection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getparseAiracDataSelection.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.getparseAiracDataSelection.Location = new System.Drawing.Point(68, 117);
            this.getparseAiracDataSelection.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.getparseAiracDataSelection.Name = "getparseAiracDataSelection";
            this.getparseAiracDataSelection.Size = new System.Drawing.Size(267, 25);
            this.getparseAiracDataSelection.TabIndex = 0;
            this.getparseAiracDataSelection.TabStop = true;
            this.getparseAiracDataSelection.Text = "Get, Parse, and Format AIRAC Data";
            this.getparseAiracDataSelection.UseVisualStyleBackColor = true;
            // 
            // convertDat2SctSelection
            // 
            this.convertDat2SctSelection.AutoSize = true;
            this.convertDat2SctSelection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertDat2SctSelection.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.convertDat2SctSelection.Location = new System.Drawing.Point(394, 156);
            this.convertDat2SctSelection.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.convertDat2SctSelection.Name = "convertDat2SctSelection";
            this.convertDat2SctSelection.Size = new System.Drawing.Size(198, 25);
            this.convertDat2SctSelection.TabIndex = 1;
            this.convertDat2SctSelection.Text = "Convert DAT file to SCT2";
            this.convertDat2SctSelection.UseVisualStyleBackColor = true;
            // 
            // airacLabel
            // 
            this.airacLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.airacLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.airacLabel.Location = new System.Drawing.Point(60, 29);
            this.airacLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.airacLabel.Name = "airacLabel";
            this.airacLabel.Size = new System.Drawing.Size(610, 60);
            this.airacLabel.TabIndex = 2;
            this.airacLabel.Text = "Select what you would like to do, Pal.";
            this.airacLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // airacCycleGroupBox
            // 
            this.airacCycleGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.airacCycleGroupBox.Controls.Add(this.landingStartButton);
            this.airacCycleGroupBox.Controls.Add(this.manageFacDataSelector);
            this.airacCycleGroupBox.Controls.Add(this.convertSct2FaaGeoMap);
            this.airacCycleGroupBox.Controls.Add(this.convertFaaGeoMap2SCT);
            this.airacCycleGroupBox.Controls.Add(this.convertSct2KmlSelection);
            this.airacCycleGroupBox.Controls.Add(this.convertKml2SCTSelection);
            this.airacCycleGroupBox.Controls.Add(this.convertDxf2SctSelection);
            this.airacCycleGroupBox.Controls.Add(this.convertSct2DxfSelection);
            this.airacCycleGroupBox.Controls.Add(this.airacLabel);
            this.airacCycleGroupBox.Controls.Add(this.getparseAiracDataSelection);
            this.airacCycleGroupBox.Controls.Add(this.convertDat2SctSelection);
            this.airacCycleGroupBox.Location = new System.Drawing.Point(20, 27);
            this.airacCycleGroupBox.Name = "airacCycleGroupBox";
            this.airacCycleGroupBox.Size = new System.Drawing.Size(746, 365);
            this.airacCycleGroupBox.TabIndex = 12;
            this.airacCycleGroupBox.TabStop = false;
            // 
            // landingStartButton
            // 
            this.landingStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.landingStartButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.landingStartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.landingStartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.landingStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.landingStartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.landingStartButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.landingStartButton.Location = new System.Drawing.Point(527, 306);
            this.landingStartButton.Name = "landingStartButton";
            this.landingStartButton.Size = new System.Drawing.Size(182, 34);
            this.landingStartButton.TabIndex = 12;
            this.landingStartButton.Text = "Let\'s Start, Friend.";
            this.landingStartButton.UseVisualStyleBackColor = false;
            this.landingStartButton.Click += new System.EventHandler(this.landingStartButton_Click);
            this.landingStartButton.MouseHover += new System.EventHandler(this.landingStartButton_MouseHover);
            // 
            // manageFacDataSelector
            // 
            this.manageFacDataSelector.AutoSize = true;
            this.manageFacDataSelector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manageFacDataSelector.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.manageFacDataSelector.Location = new System.Drawing.Point(394, 117);
            this.manageFacDataSelector.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.manageFacDataSelector.Name = "manageFacDataSelector";
            this.manageFacDataSelector.Size = new System.Drawing.Size(197, 25);
            this.manageFacDataSelector.TabIndex = 9;
            this.manageFacDataSelector.Text = "Manage My Facility Data";
            this.manageFacDataSelector.UseVisualStyleBackColor = true;
            // 
            // convertSct2FaaGeoMap
            // 
            this.convertSct2FaaGeoMap.AutoSize = true;
            this.convertSct2FaaGeoMap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertSct2FaaGeoMap.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.convertSct2FaaGeoMap.Location = new System.Drawing.Point(394, 234);
            this.convertSct2FaaGeoMap.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.convertSct2FaaGeoMap.Name = "convertSct2FaaGeoMap";
            this.convertSct2FaaGeoMap.Size = new System.Drawing.Size(273, 25);
            this.convertSct2FaaGeoMap.TabIndex = 8;
            this.convertSct2FaaGeoMap.Text = "Convert SCT2 to FAA GeoMap (.???)";
            this.convertSct2FaaGeoMap.UseVisualStyleBackColor = true;
            // 
            // convertFaaGeoMap2SCT
            // 
            this.convertFaaGeoMap2SCT.AutoSize = true;
            this.convertFaaGeoMap2SCT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertFaaGeoMap2SCT.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.convertFaaGeoMap2SCT.Location = new System.Drawing.Point(394, 195);
            this.convertFaaGeoMap2SCT.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.convertFaaGeoMap2SCT.Name = "convertFaaGeoMap2SCT";
            this.convertFaaGeoMap2SCT.Size = new System.Drawing.Size(273, 25);
            this.convertFaaGeoMap2SCT.TabIndex = 7;
            this.convertFaaGeoMap2SCT.Text = "Convert FAA GeoMap (.???) to SCT2";
            this.convertFaaGeoMap2SCT.UseVisualStyleBackColor = true;
            // 
            // convertSct2KmlSelection
            // 
            this.convertSct2KmlSelection.AutoSize = true;
            this.convertSct2KmlSelection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertSct2KmlSelection.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.convertSct2KmlSelection.Location = new System.Drawing.Point(68, 273);
            this.convertSct2KmlSelection.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.convertSct2KmlSelection.Name = "convertSct2KmlSelection";
            this.convertSct2KmlSelection.Size = new System.Drawing.Size(176, 25);
            this.convertSct2KmlSelection.TabIndex = 6;
            this.convertSct2KmlSelection.Text = "Convert SCT2 to KML";
            this.convertSct2KmlSelection.UseVisualStyleBackColor = true;
            // 
            // convertKml2SCTSelection
            // 
            this.convertKml2SCTSelection.AutoSize = true;
            this.convertKml2SCTSelection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertKml2SCTSelection.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.convertKml2SCTSelection.Location = new System.Drawing.Point(68, 234);
            this.convertKml2SCTSelection.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.convertKml2SCTSelection.Name = "convertKml2SCTSelection";
            this.convertKml2SCTSelection.Size = new System.Drawing.Size(176, 25);
            this.convertKml2SCTSelection.TabIndex = 5;
            this.convertKml2SCTSelection.Text = "Convert KML to SCT2";
            this.convertKml2SCTSelection.UseVisualStyleBackColor = true;
            // 
            // convertDxf2SctSelection
            // 
            this.convertDxf2SctSelection.AutoSize = true;
            this.convertDxf2SctSelection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertDxf2SctSelection.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.convertDxf2SctSelection.Location = new System.Drawing.Point(68, 195);
            this.convertDxf2SctSelection.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.convertDxf2SctSelection.Name = "convertDxf2SctSelection";
            this.convertDxf2SctSelection.Size = new System.Drawing.Size(173, 25);
            this.convertDxf2SctSelection.TabIndex = 4;
            this.convertDxf2SctSelection.Text = "Convert DXF to SCT2";
            this.convertDxf2SctSelection.UseVisualStyleBackColor = true;
            // 
            // convertSct2DxfSelection
            // 
            this.convertSct2DxfSelection.AutoSize = true;
            this.convertSct2DxfSelection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertSct2DxfSelection.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.convertSct2DxfSelection.Location = new System.Drawing.Point(68, 156);
            this.convertSct2DxfSelection.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.convertSct2DxfSelection.Name = "convertSct2DxfSelection";
            this.convertSct2DxfSelection.Size = new System.Drawing.Size(173, 25);
            this.convertSct2DxfSelection.TabIndex = 3;
            this.convertSct2DxfSelection.Text = "Convert SCT2 to DXF";
            this.convertSct2DxfSelection.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.reportIssuesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(785, 26);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InstructionsMenuItem,
            this.RoadmapMenuItem,
            this.FAQMenuItem,
            this.ChangeLogMenuItem,
            this.CreditsMenuItem});
            this.informationToolStripMenuItem.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.informationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // InstructionsMenuItem
            // 
            this.InstructionsMenuItem.BackColor = System.Drawing.Color.Black;
            this.InstructionsMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InstructionsMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InstructionsMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.InstructionsMenuItem.Name = "InstructionsMenuItem";
            this.InstructionsMenuItem.Size = new System.Drawing.Size(155, 22);
            this.InstructionsMenuItem.Text = "Instructions";
            this.InstructionsMenuItem.Click += new System.EventHandler(this.InstructionsMenuItem_Click);
            // 
            // RoadmapMenuItem
            // 
            this.RoadmapMenuItem.BackColor = System.Drawing.Color.Black;
            this.RoadmapMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RoadmapMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RoadmapMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.RoadmapMenuItem.Name = "RoadmapMenuItem";
            this.RoadmapMenuItem.Size = new System.Drawing.Size(155, 22);
            this.RoadmapMenuItem.Text = "Roadmap";
            this.RoadmapMenuItem.Click += new System.EventHandler(this.RoadmapMenuItem_Click);
            // 
            // FAQMenuItem
            // 
            this.FAQMenuItem.BackColor = System.Drawing.Color.Black;
            this.FAQMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FAQMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FAQMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FAQMenuItem.Name = "FAQMenuItem";
            this.FAQMenuItem.Size = new System.Drawing.Size(155, 22);
            this.FAQMenuItem.Text = "FAQ";
            this.FAQMenuItem.Click += new System.EventHandler(this.FAQMenuItem_Click);
            // 
            // ChangeLogMenuItem
            // 
            this.ChangeLogMenuItem.BackColor = System.Drawing.Color.Black;
            this.ChangeLogMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChangeLogMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ChangeLogMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ChangeLogMenuItem.Name = "ChangeLogMenuItem";
            this.ChangeLogMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ChangeLogMenuItem.Text = "Change Log";
            this.ChangeLogMenuItem.Click += new System.EventHandler(this.ChangeLogMenuItem_Click);
            // 
            // CreditsMenuItem
            // 
            this.CreditsMenuItem.BackColor = System.Drawing.Color.Black;
            this.CreditsMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreditsMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CreditsMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CreditsMenuItem.Name = "CreditsMenuItem";
            this.CreditsMenuItem.Size = new System.Drawing.Size(155, 22);
            this.CreditsMenuItem.Text = "Credits";
            this.CreditsMenuItem.Click += new System.EventHandler(this.CreditsMenuItem_Click);
            // 
            // reportIssuesToolStripMenuItem
            // 
            this.reportIssuesToolStripMenuItem.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportIssuesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.reportIssuesToolStripMenuItem.Name = "reportIssuesToolStripMenuItem";
            this.reportIssuesToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.reportIssuesToolStripMenuItem.Text = "Report Issues";
            this.reportIssuesToolStripMenuItem.Click += new System.EventHandler(this.reportIssuesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UninstallMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // UninstallMenuItem
            // 
            this.UninstallMenuItem.BackColor = System.Drawing.Color.Black;
            this.UninstallMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UninstallMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.UninstallMenuItem.Name = "UninstallMenuItem";
            this.UninstallMenuItem.Size = new System.Drawing.Size(133, 22);
            this.UninstallMenuItem.Text = "Uninstall";
            this.UninstallMenuItem.Click += new System.EventHandler(this.UninstallMenuItem_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BackgroundImage = global::FeBuddyWinFormUI.Properties.Resources.window_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 404);
            this.Controls.Add(this.airacCycleGroupBox);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "LandingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FE-BUDDY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LandingForm_Closing);
            this.Load += new System.EventHandler(this.LandingForm_Load);
            this.Shown += new System.EventHandler(this.LandingForm_Shown);
            this.airacCycleGroupBox.ResumeLayout(false);
            this.airacCycleGroupBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton getparseAiracDataSelection;
        private System.Windows.Forms.RadioButton convertDat2SctSelection;
        private System.Windows.Forms.Label airacLabel;
        private System.Windows.Forms.GroupBox airacCycleGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UninstallMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InstructionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoadmapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FAQMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeLogMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreditsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportIssuesToolStripMenuItem;
        private System.Windows.Forms.RadioButton convertSct2FaaGeoMap;
        private System.Windows.Forms.RadioButton convertFaaGeoMap2SCT;
        private System.Windows.Forms.RadioButton convertSct2KmlSelection;
        private System.Windows.Forms.RadioButton convertKml2SCTSelection;
        private System.Windows.Forms.RadioButton convertDxf2SctSelection;
        private System.Windows.Forms.RadioButton convertSct2DxfSelection;
        private System.Windows.Forms.Button landingStartButton;
        private System.Windows.Forms.RadioButton manageFacDataSelector;
    }
}
