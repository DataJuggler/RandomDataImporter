

#region using statements


#endregion

namespace RandomDataImporter
{

    #region class RandomDataForm
    /// <summary>
    /// This is the designer for the RandomDataForm
    /// </summary>
    partial class RandomDataForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.TextBox ResultsTextBox;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
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
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.GetDataButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.UpdateEmailButton = new DataJuggler.Win.Controls.Button();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // GetDataButton
            // 
            this.GetDataButton.BackColor = System.Drawing.Color.Transparent;
            this.GetDataButton.BackgroundImage = global::RandomDataImporter.Properties.Resources.WoodButtonWidth640;
            this.GetDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GetDataButton.FlatAppearance.BorderSize = 0;
            this.GetDataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GetDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GetDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetDataButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetDataButton.Location = new System.Drawing.Point(36, 16);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(193, 47);
            this.GetDataButton.TabIndex = 0;
            this.GetDataButton.Text = "Get Random Data";
            this.GetDataButton.UseVisualStyleBackColor = false;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            this.GetDataButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.GetDataButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(36, 69);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(886, 304);
            this.ResultsTextBox.TabIndex = 1;
            // 
            // UpdateEmailButton
            // 
            this.UpdateEmailButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateEmailButton.ButtonText = "Update Email";
            this.UpdateEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateEmailButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateEmailButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateEmailButton.Location = new System.Drawing.Point(288, 16);
            this.UpdateEmailButton.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateEmailButton.Name = "UpdateEmailButton";
            this.UpdateEmailButton.Size = new System.Drawing.Size(193, 47);
            this.UpdateEmailButton.TabIndex = 2;
            this.UpdateEmailButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Wood;
            this.UpdateEmailButton.Click += new System.EventHandler(this.UpdateEmailButton_Click);
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(36, 396);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(886, 23);
            this.Graph.TabIndex = 4;
            this.Graph.Visible = false;
            // 
            // RandomDataForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::RandomDataImporter.Properties.Resources.Black_Textured_Small;
            this.ClientSize = new System.Drawing.Size(960, 446);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.UpdateEmailButton);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.GetDataButton);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "RandomDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Data Form";
            this.ResumeLayout(false);
            this.PerformLayout();

            }
        #endregion

        #endregion

        private DataJuggler.Win.Controls.Button UpdateEmailButton;
        private System.Windows.Forms.ProgressBar Graph;
    }
    #endregion

}
