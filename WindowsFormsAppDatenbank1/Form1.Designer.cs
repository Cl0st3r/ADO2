namespace WindowsFormsAppDatenbank1
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.buttonAuslesen = new System.Windows.Forms.Button();
            this.listBoxAusgabe = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.toolStripStatusLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(44, 69);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(148, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Verbindung aufbauen:";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripStatusLabel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStripStatusLabel.Location = new System.Drawing.Point(0, 280);
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(284, 25);
            this.toolStripStatusLabel.TabIndex = 1;
            this.toolStripStatusLabel.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // buttonCommand
            // 
            this.buttonCommand.Location = new System.Drawing.Point(44, 99);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(148, 23);
            this.buttonCommand.TabIndex = 2;
            this.buttonCommand.Text = "Command";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // buttonAuslesen
            // 
            this.buttonAuslesen.Location = new System.Drawing.Point(44, 129);
            this.buttonAuslesen.Name = "buttonAuslesen";
            this.buttonAuslesen.Size = new System.Drawing.Size(148, 23);
            this.buttonAuslesen.TabIndex = 3;
            this.buttonAuslesen.Text = "Daten Auslesen";
            this.buttonAuslesen.UseVisualStyleBackColor = true;
            this.buttonAuslesen.Click += new System.EventHandler(this.buttonAuslesen_Click);
            // 
            // listBoxAusgabe
            // 
            this.listBoxAusgabe.FormattingEnabled = true;
            this.listBoxAusgabe.Location = new System.Drawing.Point(44, 166);
            this.listBoxAusgabe.Name = "listBoxAusgabe";
            this.listBoxAusgabe.Size = new System.Drawing.Size(120, 95);
            this.listBoxAusgabe.TabIndex = 4;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(192, 237);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 305);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listBoxAusgabe);
            this.Controls.Add(this.buttonAuslesen);
            this.Controls.Add(this.buttonCommand);
            this.Controls.Add(this.toolStripStatusLabel);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "OleDb - Zugriff";
            this.toolStripStatusLabel.ResumeLayout(false);
            this.toolStripStatusLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ToolStrip toolStripStatusLabel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.Button buttonAuslesen;
        private System.Windows.Forms.ListBox listBoxAusgabe;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

