﻿namespace AquaModelTool
{
    partial class AquaModelTool
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageNormalsOnSharedPositionVerticesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClassicPlayerAnimToNGSAnimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parseVTBFToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parsePSO2TextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readCMXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parseIncaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readBonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePanel = new System.Windows.Forms.Panel();
            this.generateCharacterFileSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.extraToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageNormalsOnSharedPositionVerticesToolStripMenuItem,
            this.updateClassicPlayerAnimToNGSAnimToolStripMenuItem,
            this.generateCharacterFileSheetToolStripMenuItem});
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // averageNormalsOnSharedPositionVerticesToolStripMenuItem
            // 
            this.averageNormalsOnSharedPositionVerticesToolStripMenuItem.Name = "averageNormalsOnSharedPositionVerticesToolStripMenuItem";
            this.averageNormalsOnSharedPositionVerticesToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.averageNormalsOnSharedPositionVerticesToolStripMenuItem.Text = "Average Normals on shared position vertices";
            this.averageNormalsOnSharedPositionVerticesToolStripMenuItem.Click += new System.EventHandler(this.averageNormalsOnSharedPositionVerticesToolStripMenuItem_Click);
            // 
            // updateClassicPlayerAnimToNGSAnimToolStripMenuItem
            // 
            this.updateClassicPlayerAnimToNGSAnimToolStripMenuItem.Name = "updateClassicPlayerAnimToNGSAnimToolStripMenuItem";
            this.updateClassicPlayerAnimToNGSAnimToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.updateClassicPlayerAnimToNGSAnimToolStripMenuItem.Text = "Update classic player anim to NGS anim";
            this.updateClassicPlayerAnimToNGSAnimToolStripMenuItem.Click += new System.EventHandler(this.updateClassicPlayerAnimToNGSAnimToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parseVTBFToTextToolStripMenuItem,
            this.parsePSO2TextToolStripMenuItem,
            this.readCMXToolStripMenuItem,
            this.parseIncaToolStripMenuItem,
            this.readBonesToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // parseVTBFToTextToolStripMenuItem
            // 
            this.parseVTBFToTextToolStripMenuItem.Name = "parseVTBFToTextToolStripMenuItem";
            this.parseVTBFToTextToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.parseVTBFToTextToolStripMenuItem.Text = "ParseVTBFToText";
            this.parseVTBFToTextToolStripMenuItem.Click += new System.EventHandler(this.parseVTBFToTextToolStripMenuItem_Click);
            // 
            // parsePSO2TextToolStripMenuItem
            // 
            this.parsePSO2TextToolStripMenuItem.Name = "parsePSO2TextToolStripMenuItem";
            this.parsePSO2TextToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.parsePSO2TextToolStripMenuItem.Text = "ParsePSO2Text";
            this.parsePSO2TextToolStripMenuItem.Click += new System.EventHandler(this.parsePSO2TextToolStripMenuItem_Click);
            // 
            // readCMXToolStripMenuItem
            // 
            this.readCMXToolStripMenuItem.Name = "readCMXToolStripMenuItem";
            this.readCMXToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.readCMXToolStripMenuItem.Text = "ReadCMX (NIFL Only atm)";
            this.readCMXToolStripMenuItem.Click += new System.EventHandler(this.readCMXToolStripMenuItem_Click);
            // 
            // parseIncaToolStripMenuItem
            // 
            this.parseIncaToolStripMenuItem.Name = "parseIncaToolStripMenuItem";
            this.parseIncaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.parseIncaToolStripMenuItem.Text = "ParseInca";
            this.parseIncaToolStripMenuItem.Click += new System.EventHandler(this.parseIncaToolStripMenuItem_Click);
            // 
            // readBonesToolStripMenuItem
            // 
            this.readBonesToolStripMenuItem.Name = "readBonesToolStripMenuItem";
            this.readBonesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.readBonesToolStripMenuItem.Text = "ReadBones";
            this.readBonesToolStripMenuItem.Click += new System.EventHandler(this.readBonesToolStripMenuItem_Click);
            // 
            // filePanel
            // 
            this.filePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePanel.Location = new System.Drawing.Point(0, 24);
            this.filePanel.Name = "filePanel";
            this.filePanel.Size = new System.Drawing.Size(384, 256);
            this.filePanel.TabIndex = 1;
            // 
            // generateCharacterFileSheetToolStripMenuItem
            // 
            this.generateCharacterFileSheetToolStripMenuItem.Name = "generateCharacterFileSheetToolStripMenuItem";
            this.generateCharacterFileSheetToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.generateCharacterFileSheetToolStripMenuItem.Text = "GenerateCharacterFileSheet";
            this.generateCharacterFileSheetToolStripMenuItem.Click += new System.EventHandler(this.generateCharacterFileSheetToolStripMenuItem_Click_1);
            // 
            // AquaModelTool
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 280);
            this.Controls.Add(this.filePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AquaModelTool";
            this.Text = "Aqua Model Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel filePanel;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageNormalsOnSharedPositionVerticesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parseVTBFToTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readCMXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parsePSO2TextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parseIncaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readBonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClassicPlayerAnimToNGSAnimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateCharacterFileSheetToolStripMenuItem;
    }
}

