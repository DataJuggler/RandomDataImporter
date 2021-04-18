
namespace RandomDataImporter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImportAdverbsButton = new System.Windows.Forms.Button();
            this.AdverbsGraph = new System.Windows.Forms.ProgressBar();
            this.AdverbStatusLabel = new System.Windows.Forms.Label();
            this.AdjectiveStatusLabel = new System.Windows.Forms.Label();
            this.AdjectiveGraph = new System.Windows.Forms.ProgressBar();
            this.ImportAdjectivesButton = new System.Windows.Forms.Button();
            this.NounStatusLabel = new System.Windows.Forms.Label();
            this.NounGraph = new System.Windows.Forms.ProgressBar();
            this.ImportNounsButton = new System.Windows.Forms.Button();
            this.VerbStatusLabel = new System.Windows.Forms.Label();
            this.VerbGraph = new System.Windows.Forms.ProgressBar();
            this.ImportVerbsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImportAdverbsButton
            // 
            this.ImportAdverbsButton.Location = new System.Drawing.Point(670, 117);
            this.ImportAdverbsButton.Name = "ImportAdverbsButton";
            this.ImportAdverbsButton.Size = new System.Drawing.Size(218, 46);
            this.ImportAdverbsButton.TabIndex = 0;
            this.ImportAdverbsButton.Text = "Import Adverbs";
            this.ImportAdverbsButton.UseVisualStyleBackColor = true;
            this.ImportAdverbsButton.Click += new System.EventHandler(this.ImportAdverbsButton_Click);
            this.ImportAdverbsButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.ImportAdverbsButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // AdverbsGraph
            // 
            this.AdverbsGraph.Location = new System.Drawing.Point(64, 44);
            this.AdverbsGraph.Name = "AdverbsGraph";
            this.AdverbsGraph.Size = new System.Drawing.Size(824, 23);
            this.AdverbsGraph.TabIndex = 1;
            // 
            // AdverbStatusLabel
            // 
            this.AdverbStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdverbStatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.AdverbStatusLabel.Location = new System.Drawing.Point(338, 80);
            this.AdverbStatusLabel.Name = "AdverbStatusLabel";
            this.AdverbStatusLabel.Size = new System.Drawing.Size(550, 34);
            this.AdverbStatusLabel.TabIndex = 2;
            this.AdverbStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdjectiveStatusLabel
            // 
            this.AdjectiveStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdjectiveStatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.AdjectiveStatusLabel.Location = new System.Drawing.Point(338, 220);
            this.AdjectiveStatusLabel.Name = "AdjectiveStatusLabel";
            this.AdjectiveStatusLabel.Size = new System.Drawing.Size(550, 34);
            this.AdjectiveStatusLabel.TabIndex = 5;
            this.AdjectiveStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdjectiveGraph
            // 
            this.AdjectiveGraph.Location = new System.Drawing.Point(64, 184);
            this.AdjectiveGraph.Name = "AdjectiveGraph";
            this.AdjectiveGraph.Size = new System.Drawing.Size(824, 23);
            this.AdjectiveGraph.TabIndex = 4;
            // 
            // ImportAdjectivesButton
            // 
            this.ImportAdjectivesButton.Location = new System.Drawing.Point(670, 257);
            this.ImportAdjectivesButton.Name = "ImportAdjectivesButton";
            this.ImportAdjectivesButton.Size = new System.Drawing.Size(218, 46);
            this.ImportAdjectivesButton.TabIndex = 3;
            this.ImportAdjectivesButton.Text = "Import Adjectives";
            this.ImportAdjectivesButton.UseVisualStyleBackColor = true;
            this.ImportAdjectivesButton.Click += new System.EventHandler(this.ImportAdjectivesButton_Click);
            this.ImportAdjectivesButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.ImportAdjectivesButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // NounStatusLabel
            // 
            this.NounStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.NounStatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.NounStatusLabel.Location = new System.Drawing.Point(338, 361);
            this.NounStatusLabel.Name = "NounStatusLabel";
            this.NounStatusLabel.Size = new System.Drawing.Size(550, 34);
            this.NounStatusLabel.TabIndex = 8;
            this.NounStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NounGraph
            // 
            this.NounGraph.Location = new System.Drawing.Point(64, 325);
            this.NounGraph.Name = "NounGraph";
            this.NounGraph.Size = new System.Drawing.Size(824, 23);
            this.NounGraph.TabIndex = 7;
            // 
            // ImportNounsButton
            // 
            this.ImportNounsButton.Location = new System.Drawing.Point(670, 398);
            this.ImportNounsButton.Name = "ImportNounsButton";
            this.ImportNounsButton.Size = new System.Drawing.Size(218, 46);
            this.ImportNounsButton.TabIndex = 6;
            this.ImportNounsButton.Text = "Import Nouns";
            this.ImportNounsButton.UseVisualStyleBackColor = true;
            this.ImportNounsButton.Click += new System.EventHandler(this.ImportNounsButton_Click);
            this.ImportNounsButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.ImportNounsButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // VerbStatusLabel
            // 
            this.VerbStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.VerbStatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.VerbStatusLabel.Location = new System.Drawing.Point(338, 512);
            this.VerbStatusLabel.Name = "VerbStatusLabel";
            this.VerbStatusLabel.Size = new System.Drawing.Size(550, 34);
            this.VerbStatusLabel.TabIndex = 11;
            this.VerbStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VerbGraph
            // 
            this.VerbGraph.Location = new System.Drawing.Point(64, 476);
            this.VerbGraph.Name = "VerbGraph";
            this.VerbGraph.Size = new System.Drawing.Size(824, 23);
            this.VerbGraph.TabIndex = 10;
            // 
            // ImportVerbsButton
            // 
            this.ImportVerbsButton.Location = new System.Drawing.Point(670, 549);
            this.ImportVerbsButton.Name = "ImportVerbsButton";
            this.ImportVerbsButton.Size = new System.Drawing.Size(218, 46);
            this.ImportVerbsButton.TabIndex = 9;
            this.ImportVerbsButton.Text = "Import Verbs";
            this.ImportVerbsButton.UseVisualStyleBackColor = true;
            this.ImportVerbsButton.Click += new System.EventHandler(this.ImportVerbsButton_Click);
            this.ImportVerbsButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.ImportVerbsButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::RandomDataImporter.Properties.Resources.Black_Textured_Small;
            this.ClientSize = new System.Drawing.Size(928, 643);
            this.Controls.Add(this.VerbStatusLabel);
            this.Controls.Add(this.VerbGraph);
            this.Controls.Add(this.ImportVerbsButton);
            this.Controls.Add(this.NounStatusLabel);
            this.Controls.Add(this.NounGraph);
            this.Controls.Add(this.ImportNounsButton);
            this.Controls.Add(this.AdjectiveStatusLabel);
            this.Controls.Add(this.AdjectiveGraph);
            this.Controls.Add(this.ImportAdjectivesButton);
            this.Controls.Add(this.AdverbStatusLabel);
            this.Controls.Add(this.AdverbsGraph);
            this.Controls.Add(this.ImportAdverbsButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Importer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImportAdverbsButton;
        private System.Windows.Forms.ProgressBar AdverbsGraph;
        private System.Windows.Forms.Label AdverbStatusLabel;
        private System.Windows.Forms.Label AdjectiveStatusLabel;
        private System.Windows.Forms.ProgressBar AdjectiveGraph;
        private System.Windows.Forms.Button ImportAdjectivesButton;
        private System.Windows.Forms.Label NounStatusLabel;
        private System.Windows.Forms.ProgressBar NounGraph;
        private System.Windows.Forms.Button ImportNounsButton;
        private System.Windows.Forms.Label VerbStatusLabel;
        private System.Windows.Forms.ProgressBar VerbGraph;
        private System.Windows.Forms.Button ImportVerbsButton;
    }
}

