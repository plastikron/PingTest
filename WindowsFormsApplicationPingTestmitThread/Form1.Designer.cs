﻿namespace WindowsFormsApplicationPingTestmitThread
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxnichtOk = new System.Windows.Forms.ListBox();
            this.listBoxOk = new System.Windows.Forms.ListBox();
            this.labelnichtOk = new System.Windows.Forms.Label();
            this.labelOk = new System.Windows.Forms.Label();
            this.buttonPing = new System.Windows.Forms.Button();
            this.listBoxTestadressen = new System.Windows.Forms.ListBox();
            this.labelTestadressen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxnichtOk
            // 
            this.listBoxnichtOk.FormattingEnabled = true;
            this.listBoxnichtOk.Location = new System.Drawing.Point(393, 120);
            this.listBoxnichtOk.Name = "listBoxnichtOk";
            this.listBoxnichtOk.Size = new System.Drawing.Size(111, 95);
            this.listBoxnichtOk.TabIndex = 13;
            // 
            // listBoxOk
            // 
            this.listBoxOk.FormattingEnabled = true;
            this.listBoxOk.Location = new System.Drawing.Point(228, 120);
            this.listBoxOk.Name = "listBoxOk";
            this.listBoxOk.Size = new System.Drawing.Size(111, 95);
            this.listBoxOk.TabIndex = 12;
            // 
            // labelnichtOk
            // 
            this.labelnichtOk.AutoSize = true;
            this.labelnichtOk.Location = new System.Drawing.Point(390, 104);
            this.labelnichtOk.Name = "labelnichtOk";
            this.labelnichtOk.Size = new System.Drawing.Size(71, 13);
            this.labelnichtOk.TabIndex = 11;
            this.labelnichtOk.Text = "Ping nicht Ok";
            // 
            // labelOk
            // 
            this.labelOk.AutoSize = true;
            this.labelOk.Location = new System.Drawing.Point(225, 104);
            this.labelOk.Name = "labelOk";
            this.labelOk.Size = new System.Drawing.Size(45, 13);
            this.labelOk.TabIndex = 10;
            this.labelOk.Text = "Ping Ok";
            // 
            // buttonPing
            // 
            this.buttonPing.Location = new System.Drawing.Point(228, 46);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(276, 34);
            this.buttonPing.TabIndex = 9;
            this.buttonPing.Text = "Ping";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // listBoxTestadressen
            // 
            this.listBoxTestadressen.FormattingEnabled = true;
            this.listBoxTestadressen.Location = new System.Drawing.Point(26, 46);
            this.listBoxTestadressen.Name = "listBoxTestadressen";
            this.listBoxTestadressen.Size = new System.Drawing.Size(178, 147);
            this.listBoxTestadressen.TabIndex = 8;
            // 
            // labelTestadressen
            // 
            this.labelTestadressen.AutoSize = true;
            this.labelTestadressen.Location = new System.Drawing.Point(23, 30);
            this.labelTestadressen.Name = "labelTestadressen";
            this.labelTestadressen.Size = new System.Drawing.Size(71, 13);
            this.labelTestadressen.TabIndex = 7;
            this.labelTestadressen.Text = "Testadressen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 264);
            this.Controls.Add(this.listBoxnichtOk);
            this.Controls.Add(this.listBoxOk);
            this.Controls.Add(this.labelnichtOk);
            this.Controls.Add(this.labelOk);
            this.Controls.Add(this.buttonPing);
            this.Controls.Add(this.listBoxTestadressen);
            this.Controls.Add(this.labelTestadressen);
            this.Name = "Form1";
            this.Text = "PingTest mit Thread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxnichtOk;
        private System.Windows.Forms.ListBox listBoxOk;
        private System.Windows.Forms.Label labelnichtOk;
        private System.Windows.Forms.Label labelOk;
        private System.Windows.Forms.Button buttonPing;
        private System.Windows.Forms.ListBox listBoxTestadressen;
        private System.Windows.Forms.Label labelTestadressen;
    }
}

