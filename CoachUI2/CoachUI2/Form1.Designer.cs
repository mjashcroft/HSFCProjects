namespace CoachUI2
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
            this.AddToBusButton = new System.Windows.Forms.Button();
            this.GetByNameButton = new System.Windows.Forms.Button();
            this.RemoveByNameButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SeatLabel = new System.Windows.Forms.Label();
            this.SeatTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddToBusButton
            // 
            this.AddToBusButton.BackColor = System.Drawing.Color.Red;
            this.AddToBusButton.BackgroundImage = global::CoachUI2.Properties.Resources.smashed_bus;
            this.AddToBusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddToBusButton.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToBusButton.ForeColor = System.Drawing.Color.Red;
            this.AddToBusButton.Location = new System.Drawing.Point(445, 302);
            this.AddToBusButton.Name = "AddToBusButton";
            this.AddToBusButton.Size = new System.Drawing.Size(172, 137);
            this.AddToBusButton.TabIndex = 0;
            this.AddToBusButton.Text = "Add to bus";
            this.AddToBusButton.UseVisualStyleBackColor = false;
            this.AddToBusButton.Click += new System.EventHandler(this.AddToBusButton_Click);
            // 
            // GetByNameButton
            // 
            this.GetByNameButton.BackColor = System.Drawing.Color.Red;
            this.GetByNameButton.BackgroundImage = global::CoachUI2.Properties.Resources.smashed_bus;
            this.GetByNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GetByNameButton.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetByNameButton.ForeColor = System.Drawing.Color.Red;
            this.GetByNameButton.Location = new System.Drawing.Point(680, 302);
            this.GetByNameButton.Name = "GetByNameButton";
            this.GetByNameButton.Size = new System.Drawing.Size(172, 137);
            this.GetByNameButton.TabIndex = 1;
            this.GetByNameButton.Text = "Get by name";
            this.GetByNameButton.UseVisualStyleBackColor = false;
            this.GetByNameButton.Click += new System.EventHandler(this.GetByNameButton_Click);
            // 
            // RemoveByNameButton
            // 
            this.RemoveByNameButton.BackColor = System.Drawing.Color.Red;
            this.RemoveByNameButton.BackgroundImage = global::CoachUI2.Properties.Resources.smashed_bus;
            this.RemoveByNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveByNameButton.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveByNameButton.ForeColor = System.Drawing.Color.Red;
            this.RemoveByNameButton.Location = new System.Drawing.Point(208, 302);
            this.RemoveByNameButton.Name = "RemoveByNameButton";
            this.RemoveByNameButton.Size = new System.Drawing.Size(172, 137);
            this.RemoveByNameButton.TabIndex = 2;
            this.RemoveByNameButton.Text = "Remove by name";
            this.RemoveByNameButton.UseVisualStyleBackColor = false;
            this.RemoveByNameButton.Click += new System.EventHandler(this.RemoveByNameButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Red;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(229, 134);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(78, 29);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.BackColor = System.Drawing.Color.Red;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(313, 189);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(56, 29);
            this.AgeLabel.TabIndex = 4;
            this.AgeLabel.Text = "Age";
            // 
            // SeatLabel
            // 
            this.SeatLabel.AutoSize = true;
            this.SeatLabel.BackColor = System.Drawing.Color.Red;
            this.SeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatLabel.Location = new System.Drawing.Point(587, 189);
            this.SeatLabel.Name = "SeatLabel";
            this.SeatLabel.Size = new System.Drawing.Size(62, 29);
            this.SeatLabel.TabIndex = 5;
            this.SeatLabel.Text = "Seat";
            // 
            // SeatTextBox
            // 
            this.SeatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatTextBox.Location = new System.Drawing.Point(655, 186);
            this.SeatTextBox.Name = "SeatTextBox";
            this.SeatTextBox.Size = new System.Drawing.Size(120, 35);
            this.SeatTextBox.TabIndex = 6;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.Location = new System.Drawing.Point(375, 186);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(42, 35);
            this.AgeTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(313, 131);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(462, 35);
            this.NameTextBox.TabIndex = 8;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Red;
            this.TitleLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(318, 46);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(445, 42);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "Mike\'s coach booking";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(868, 400);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 39);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Mike";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoachUI2.Properties.Resources.bus;
            this.ClientSize = new System.Drawing.Size(1051, 615);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.SeatTextBox);
            this.Controls.Add(this.SeatLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RemoveByNameButton);
            this.Controls.Add(this.GetByNameButton);
            this.Controls.Add(this.AddToBusButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddToBusButton;
        private System.Windows.Forms.Button GetByNameButton;
        private System.Windows.Forms.Button RemoveByNameButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label SeatLabel;
        private System.Windows.Forms.TextBox SeatTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox textBox4;
    }
}

