namespace Py_CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdBrowseScript = new System.Windows.Forms.Button();
            this.CmdRunScript = new System.Windows.Forms.Button();
            this.CmdClearOutput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInputScriptPath = new System.Windows.Forms.TextBox();
            this.txtInputScript = new System.Windows.Forms.TextBox();
            this.radInputFromFile = new System.Windows.Forms.RadioButton();
            this.radInputFromForm = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // CmdBrowseScript
            // 
            this.CmdBrowseScript.Location = new System.Drawing.Point(269, 44);
            this.CmdBrowseScript.Name = "CmdBrowseScript";
            this.CmdBrowseScript.Size = new System.Drawing.Size(75, 23);
            this.CmdBrowseScript.TabIndex = 0;
            this.CmdBrowseScript.Text = "Browse..";
            this.CmdBrowseScript.UseVisualStyleBackColor = true;
            this.CmdBrowseScript.Click += new System.EventHandler(this.CmdBrowseScript_Click);
            // 
            // CmdRunScript
            // 
            this.CmdRunScript.Location = new System.Drawing.Point(17, 194);
            this.CmdRunScript.Name = "CmdRunScript";
            this.CmdRunScript.Size = new System.Drawing.Size(75, 23);
            this.CmdRunScript.TabIndex = 1;
            this.CmdRunScript.Text = "Run Script";
            this.CmdRunScript.UseVisualStyleBackColor = true;
            this.CmdRunScript.Click += new System.EventHandler(this.CmdRunScript_Click);
            // 
            // CmdClearOutput
            // 
            this.CmdClearOutput.Location = new System.Drawing.Point(17, 415);
            this.CmdClearOutput.Name = "CmdClearOutput";
            this.CmdClearOutput.Size = new System.Drawing.Size(75, 23);
            this.CmdClearOutput.TabIndex = 4;
            this.CmdClearOutput.Text = "Clear ..";
            this.CmdClearOutput.UseVisualStyleBackColor = true;
            this.CmdClearOutput.Click += new System.EventHandler(this.CmdClearOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.LightGray;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtOutput.Location = new System.Drawing.Point(98, 194);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(445, 244);
            this.txtOutput.TabIndex = 5;
            // 
            // txtInputScriptPath
            // 
            this.txtInputScriptPath.BackColor = System.Drawing.Color.LightGray;
            this.txtInputScriptPath.Location = new System.Drawing.Point(98, 18);
            this.txtInputScriptPath.Name = "txtInputScriptPath";
            this.txtInputScriptPath.Size = new System.Drawing.Size(445, 20);
            this.txtInputScriptPath.TabIndex = 6;
            // 
            // txtInputScript
            // 
            this.txtInputScript.BackColor = System.Drawing.Color.LightGray;
            this.txtInputScript.Location = new System.Drawing.Point(98, 77);
            this.txtInputScript.Multiline = true;
            this.txtInputScript.Name = "txtInputScript";
            this.txtInputScript.Size = new System.Drawing.Size(445, 85);
            this.txtInputScript.TabIndex = 7;
            // 
            // radInputFromFile
            // 
            this.radInputFromFile.AutoSize = true;
            this.radInputFromFile.Location = new System.Drawing.Point(17, 20);
            this.radInputFromFile.Name = "radInputFromFile";
            this.radInputFromFile.Size = new System.Drawing.Size(64, 17);
            this.radInputFromFile.TabIndex = 8;
            this.radInputFromFile.TabStop = true;
            this.radInputFromFile.Text = "from File";
            this.radInputFromFile.UseVisualStyleBackColor = true;
            this.radInputFromFile.CheckedChanged += new System.EventHandler(this.RadInputFromFile_CheckedChanged);
            // 
            // radInputFromForm
            // 
            this.radInputFromForm.AutoSize = true;
            this.radInputFromForm.Location = new System.Drawing.Point(17, 77);
            this.radInputFromForm.Name = "radInputFromForm";
            this.radInputFromForm.Size = new System.Drawing.Size(52, 17);
            this.radInputFromForm.TabIndex = 9;
            this.radInputFromForm.TabStop = true;
            this.radInputFromForm.Text = "Script";
            this.radInputFromForm.UseVisualStyleBackColor = true;
            this.radInputFromForm.CheckedChanged += new System.EventHandler(this.RadInputFromForm_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.radInputFromForm);
            this.Controls.Add(this.radInputFromFile);
            this.Controls.Add(this.txtInputScript);
            this.Controls.Add(this.txtInputScriptPath);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.CmdClearOutput);
            this.Controls.Add(this.CmdRunScript);
            this.Controls.Add(this.CmdBrowseScript);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Py_CSharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdBrowseScript;
        private System.Windows.Forms.Button CmdRunScript;
        private System.Windows.Forms.Button CmdClearOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInputScriptPath;
        private System.Windows.Forms.TextBox txtInputScript;
        private System.Windows.Forms.RadioButton radInputFromFile;
        private System.Windows.Forms.RadioButton radInputFromForm;
    }
}

