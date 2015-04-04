namespace Draughs1
{
    partial class MenuForm
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
            this.buttonMenuClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.playerOptions = new System.Windows.Forms.ComboBox();
            this.difficultyOptions = new System.Windows.Forms.ComboBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMenuClose
            // 
            this.buttonMenuClose.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonMenuClose.Location = new System.Drawing.Point(12, 216);
            this.buttonMenuClose.Name = "buttonMenuClose";
            this.buttonMenuClose.Size = new System.Drawing.Size(126, 33);
            this.buttonMenuClose.TabIndex = 0;
            this.buttonMenuClose.Text = "Close Menu";
            this.buttonMenuClose.UseVisualStyleBackColor = false;
            this.buttonMenuClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // playerOptions
            // 
            this.playerOptions.FormattingEnabled = true;
            this.playerOptions.Items.AddRange(new object[] {
            "Human Vs. Human",
            "Human Vs. Computer",
            "Computer Vs. Human"});
            this.playerOptions.Location = new System.Drawing.Point(134, 145);
            this.playerOptions.Name = "playerOptions";
            this.playerOptions.Size = new System.Drawing.Size(136, 21);
            this.playerOptions.TabIndex = 2;
            // 
            // difficultyOptions
            // 
            this.difficultyOptions.FormattingEnabled = true;
            this.difficultyOptions.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.difficultyOptions.Location = new System.Drawing.Point(134, 180);
            this.difficultyOptions.Name = "difficultyOptions";
            this.difficultyOptions.Size = new System.Drawing.Size(136, 21);
            this.difficultyOptions.TabIndex = 2;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerLabel.Location = new System.Drawing.Point(12, 148);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(41, 13);
            this.playerLabel.TabIndex = 3;
            this.playerLabel.Text = "Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Computer Difficulty";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.exitButton.Location = new System.Drawing.Point(149, 215);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(123, 33);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit Game";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.titleLabel.Location = new System.Drawing.Point(12, -2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(268, 76);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Draughts :)";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Draughs1.Properties.Resources.Black2;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.difficultyOptions);
            this.Controls.Add(this.playerOptions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMenuClose);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMenuClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox playerOptions;
        private System.Windows.Forms.ComboBox difficultyOptions;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
    }
}