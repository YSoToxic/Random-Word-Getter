
namespace Desktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.btnGetWord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnImportWords = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblWordOutput = new System.Windows.Forms.Label();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.lblCurrentFileName = new System.Windows.Forms.Label();
            this.iconPenal = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.headerPanel.Controls.Add(this.iconPenal);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(500, 45);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseUp);
            // 
            // btnGetWord
            // 
            this.btnGetWord.BackColor = System.Drawing.Color.DarkGray;
            this.btnGetWord.FlatAppearance.BorderSize = 0;
            this.btnGetWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetWord.ForeColor = System.Drawing.Color.White;
            this.btnGetWord.Location = new System.Drawing.Point(400, 165);
            this.btnGetWord.Name = "btnGetWord";
            this.btnGetWord.Size = new System.Drawing.Size(100, 35);
            this.btnGetWord.TabIndex = 1;
            this.btnGetWord.Text = "Get Word";
            this.btnGetWord.UseVisualStyleBackColor = false;
            this.btnGetWord.Click += new System.EventHandler(this.btnGetWord_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 165);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilePath.Location = new System.Drawing.Point(115, 50);
            this.tbFilePath.Multiline = true;
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(365, 24);
            this.tbFilePath.TabIndex = 3;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(0, 50);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(114, 24);
            this.lblFilePath.TabIndex = 4;
            this.lblFilePath.Text = "Current Path";
            // 
            // btnImportWords
            // 
            this.btnImportWords.BackColor = System.Drawing.Color.DarkGray;
            this.btnImportWords.FlatAppearance.BorderSize = 0;
            this.btnImportWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportWords.ForeColor = System.Drawing.Color.White;
            this.btnImportWords.Location = new System.Drawing.Point(220, 165);
            this.btnImportWords.Name = "btnImportWords";
            this.btnImportWords.Size = new System.Drawing.Size(150, 35);
            this.btnImportWords.TabIndex = 5;
            this.btnImportWords.Text = "Import Words";
            this.btnImportWords.UseVisualStyleBackColor = false;
            this.btnImportWords.Click += new System.EventHandler(this.btnImportWords_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(0, 120);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(81, 25);
            this.lblWord.TabIndex = 6;
            this.lblWord.Text = "Word =";
            // 
            // lblWordOutput
            // 
            this.lblWordOutput.AutoSize = true;
            this.lblWordOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordOutput.Location = new System.Drawing.Point(75, 120);
            this.lblWordOutput.Name = "lblWordOutput";
            this.lblWordOutput.Size = new System.Drawing.Size(49, 25);
            this.lblWordOutput.TabIndex = 7;
            this.lblWordOutput.Text = "Null";
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFile.Location = new System.Drawing.Point(0, 85);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(124, 24);
            this.lblCurrentFile.TabIndex = 8;
            this.lblCurrentFile.Text = "Current File =";
            // 
            // lblCurrentFileName
            // 
            this.lblCurrentFileName.AutoSize = true;
            this.lblCurrentFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFileName.Location = new System.Drawing.Point(120, 85);
            this.lblCurrentFileName.Name = "lblCurrentFileName";
            this.lblCurrentFileName.Size = new System.Drawing.Size(43, 24);
            this.lblCurrentFileName.TabIndex = 9;
            this.lblCurrentFileName.Text = "Null";
            // 
            // iconPenal
            // 
            this.iconPenal.BackgroundImage = global::Desktop.Properties.Resources.random;
            this.iconPenal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPenal.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPenal.Location = new System.Drawing.Point(0, 0);
            this.iconPenal.Name = "iconPenal";
            this.iconPenal.Size = new System.Drawing.Size(50, 45);
            this.iconPenal.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.lblCurrentFileName);
            this.Controls.Add(this.lblCurrentFile);
            this.Controls.Add(this.lblWordOutput);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnImportWords);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetWord);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Word Getter";
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button btnGetWord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnImportWords;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblWordOutput;
        private System.Windows.Forms.Label lblCurrentFile;
        private System.Windows.Forms.Label lblCurrentFileName;
        private System.Windows.Forms.Panel iconPenal;
    }
}