// Sports Tactics Board
//
// http://sportstacticsbd.sourceforge.net/
// http://sourceforge.net/projects/sportstacticsbd/
// 
// Sports Tactics Board is a utility that allows coaches, trainers and 
// officials to describe sports tactics, strategies and positioning using 
// a magnetic or chalk-board style approach.
// 
// Copyright (C) 2006 Robert Turner
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//
namespace SportsTacticsBoard
{
  partial class AboutBox
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
      this.titleLabel = new System.Windows.Forms.Label();
      this.copyrightLabel = new System.Windows.Forms.Label();
      this.versionLabel = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.licenseTextBox = new System.Windows.Forms.TextBox();
      this.webSiteLinkLabel = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // titleLabel
      // 
      resources.ApplyResources(this.titleLabel, "titleLabel");
      this.titleLabel.Name = "titleLabel";
      // 
      // copyrightLabel
      // 
      resources.ApplyResources(this.copyrightLabel, "copyrightLabel");
      this.copyrightLabel.Name = "copyrightLabel";
      // 
      // versionLabel
      // 
      resources.ApplyResources(this.versionLabel, "versionLabel");
      this.versionLabel.Name = "versionLabel";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // licenseTextBox
      // 
      resources.ApplyResources(this.licenseTextBox, "licenseTextBox");
      this.licenseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.licenseTextBox.CausesValidation = false;
      this.licenseTextBox.Name = "licenseTextBox";
      this.licenseTextBox.ReadOnly = true;
      this.licenseTextBox.TabStop = false;
      // 
      // webSiteLinkLabel
      // 
      resources.ApplyResources(this.webSiteLinkLabel, "webSiteLinkLabel");
      this.webSiteLinkLabel.Name = "webSiteLinkLabel";
      this.webSiteLinkLabel.TabStop = true;
      this.webSiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.webSiteLinkLabel_LinkClicked);
      // 
      // AboutBox
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.webSiteLinkLabel);
      this.Controls.Add(this.licenseTextBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.versionLabel);
      this.Controls.Add(this.copyrightLabel);
      this.Controls.Add(this.titleLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutBox";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Load += new System.EventHandler(this.AboutBox_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.Label copyrightLabel;
    private System.Windows.Forms.Label versionLabel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox licenseTextBox;
    private System.Windows.Forms.LinkLabel webSiteLinkLabel;
  }
}