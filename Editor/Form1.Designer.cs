namespace Editor
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNarrate = new System.Windows.Forms.Button();
            this.buttonAnalyse = new System.Windows.Forms.Button();
            this.buttonFont = new System.Windows.Forms.Button();
            this.buttonSaveAudio = new System.Windows.Forms.Button();
            this.buttonVoices = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.editorField = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.analysisField = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Controls.Add(this.buttonOpen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNarrate, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAnalyse, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonFont, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSaveAudio, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonVoices, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonHelp, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 27);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(3, 3);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(61, 21);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(70, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(61, 21);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNarrate
            // 
            this.buttonNarrate.Location = new System.Drawing.Point(384, 3);
            this.buttonNarrate.Name = "buttonNarrate";
            this.buttonNarrate.Size = new System.Drawing.Size(75, 21);
            this.buttonNarrate.TabIndex = 4;
            this.buttonNarrate.Text = "Narrate";
            this.buttonNarrate.UseVisualStyleBackColor = true;
            this.buttonNarrate.Click += new System.EventHandler(this.buttonNarrate_Click);
            // 
            // buttonAnalyse
            // 
            this.buttonAnalyse.Location = new System.Drawing.Point(302, 3);
            this.buttonAnalyse.Name = "buttonAnalyse";
            this.buttonAnalyse.Size = new System.Drawing.Size(75, 21);
            this.buttonAnalyse.TabIndex = 3;
            this.buttonAnalyse.Text = "Analyse";
            this.buttonAnalyse.UseVisualStyleBackColor = true;
            this.buttonAnalyse.Click += new System.EventHandler(this.buttonAnalyse_Click);
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(220, 3);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(75, 21);
            this.buttonFont.TabIndex = 2;
            this.buttonFont.Text = "Font";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // buttonSaveAudio
            // 
            this.buttonSaveAudio.Location = new System.Drawing.Point(137, 3);
            this.buttonSaveAudio.Name = "buttonSaveAudio";
            this.buttonSaveAudio.Size = new System.Drawing.Size(75, 21);
            this.buttonSaveAudio.TabIndex = 5;
            this.buttonSaveAudio.Text = "Save Audio";
            this.buttonSaveAudio.UseVisualStyleBackColor = true;
            this.buttonSaveAudio.Click += new System.EventHandler(this.buttonSaveAudio_Click);
            // 
            // buttonVoices
            // 
            this.buttonVoices.Location = new System.Drawing.Point(468, 3);
            this.buttonVoices.Name = "buttonVoices";
            this.buttonVoices.Size = new System.Drawing.Size(75, 21);
            this.buttonVoices.TabIndex = 6;
            this.buttonVoices.Text = "View Voices";
            this.buttonVoices.UseVisualStyleBackColor = true;
            this.buttonVoices.Click += new System.EventHandler(this.buttonVoices_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(671, 3);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 21);
            this.buttonHelp.TabIndex = 7;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // editorField
            // 
            this.editorField.Location = new System.Drawing.Point(1, 30);
            this.editorField.Name = "editorField";
            this.editorField.Size = new System.Drawing.Size(563, 417);
            this.editorField.TabIndex = 1;
            this.editorField.Text = "";
            // 
            // analysisField
            // 
            this.analysisField.Location = new System.Drawing.Point(570, 30);
            this.analysisField.Name = "analysisField";
            this.analysisField.Size = new System.Drawing.Size(229, 416);
            this.analysisField.TabIndex = 2;
            this.analysisField.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.analysisField);
            this.Controls.Add(this.editorField);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Co-narrator v0.1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.Button buttonAnalyse;
        private System.Windows.Forms.Button buttonNarrate;
        private System.Windows.Forms.RichTextBox editorField;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.RichTextBox analysisField;
        private System.Windows.Forms.Button buttonSaveAudio;
        private System.Windows.Forms.Button buttonVoices;
        private System.Windows.Forms.Button buttonHelp;
    }
}

