﻿namespace WinformTemplate
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>

        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            // MainFrm
            this.main_panel.ResumeLayout(false);

    {
        }
            this.lab_status.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        #region Windows Form Designer generated code
            this.Controls.Add(this.main_panel);
            this.lab_status.Location = new System.Drawing.Point(3, 432);
        /// Required method for Designer support - do not modify
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            // MainFrm
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.main_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_status = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
        /// the contents of this method with the code editor.
            this.SuspendLayout();
            //
            // main_panel
            //
            this.main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.main_panel.Controls.Add(this.tableLayoutPanel1);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.main_panel.TabIndex = 0;
        /// the contents of this method with the code editor.
            // tableLayoutPanel1
            //
        private void InitializeComponent()
            this.SuspendLayout();
            this.tableLayoutPanel1.Controls.Add(this.lab_status, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_status.AutoSize = true;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        }
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(675, 462);
            // MainFrm
            //
            // lab_status
            //
            this.lab_status.AutoSize = true;
            this.lab_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_status.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_status.ForeColor = System.Drawing.Color.PapayaWhip;
            this.lab_status.Location = new System.Drawing.Point(3, 432);
            this.lab_status.Name = "lab_status";
            this.lab_status.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lab_status.Size = new System.Drawing.Size(669, 30);
            this.lab_status.TabIndex = 0;
            this.ResumeLayout(false);
            //
            // MainFrm
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 525);
            this.Controls.Add(this.main_panel);
        }
            this.Name = "MainFrm";
            this.Padding = new System.Windows.Forms.Padding(0, 63, 0, 0);
    }
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.main_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
        private System.Windows.Forms.Panel main_panel;
            this.ResumeLayout(false);

            this.SuspendLayout();

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
    }
        private System.Windows.Forms.Panel main_panel;