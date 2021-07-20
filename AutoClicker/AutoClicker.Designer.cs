
namespace AutoClicker
{
    partial class AutoClicker
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.IntervalsBox = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonSelect = new System.Windows.Forms.ComboBox();
            this.Options = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RepeatNumber = new System.Windows.Forms.DomainUpDown();
            this.RepeatButton = new System.Windows.Forms.RadioButton();
            this.InfinityButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.MouseY = new System.Windows.Forms.Label();
            this.MouseX = new System.Windows.Forms.Label();
            this.ClicksLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Intervals";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LawnGreen;
            this.Start.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(29, 166);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(168, 65);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start (F4)";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // IntervalsBox
            // 
            this.IntervalsBox.Location = new System.Drawing.Point(16, 10);
            this.IntervalsBox.Name = "IntervalsBox";
            this.IntervalsBox.Size = new System.Drawing.Size(100, 22);
            this.IntervalsBox.TabIndex = 3;
            this.IntervalsBox.Text = "100";
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.DarkRed;
            this.Stop.Enabled = false;
            this.Stop.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(232, 166);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(168, 65);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop (F3)";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IntervalsBox);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 47);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "milliseconds";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ButtonSelect);
            this.panel2.Location = new System.Drawing.Point(12, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 47);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Button:";
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.DisplayMember = "Left";
            this.ButtonSelect.FormattingEnabled = true;
            this.ButtonSelect.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.ButtonSelect.Location = new System.Drawing.Point(96, 13);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(100, 24);
            this.ButtonSelect.TabIndex = 0;
            // 
            // Options
            // 
            this.Options.AutoSize = true;
            this.Options.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(16, 83);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(63, 17);
            this.Options.TabIndex = 7;
            this.Options.Text = "Options";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.RepeatNumber);
            this.panel3.Controls.Add(this.RepeatButton);
            this.panel3.Controls.Add(this.InfinityButton);
            this.panel3.Location = new System.Drawing.Point(265, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 117);
            this.panel3.TabIndex = 8;
            // 
            // RepeatNumber
            // 
            this.RepeatNumber.Items.Add("+1");
            this.RepeatNumber.Items.Add("+1");
            this.RepeatNumber.Items.Add("+1");
            this.RepeatNumber.Items.Add("1");
            this.RepeatNumber.Location = new System.Drawing.Point(87, 23);
            this.RepeatNumber.Name = "RepeatNumber";
            this.RepeatNumber.Size = new System.Drawing.Size(57, 22);
            this.RepeatNumber.TabIndex = 10;
            this.RepeatNumber.Text = "1";
            // 
            // RepeatButton
            // 
            this.RepeatButton.AutoSize = true;
            this.RepeatButton.Location = new System.Drawing.Point(6, 25);
            this.RepeatButton.Name = "RepeatButton";
            this.RepeatButton.Size = new System.Drawing.Size(75, 21);
            this.RepeatButton.TabIndex = 3;
            this.RepeatButton.Text = "Repeat";
            this.RepeatButton.UseVisualStyleBackColor = true;
            // 
            // InfinityButton
            // 
            this.InfinityButton.AutoSize = true;
            this.InfinityButton.Checked = true;
            this.InfinityButton.Location = new System.Drawing.Point(6, 69);
            this.InfinityButton.Name = "InfinityButton";
            this.InfinityButton.Size = new System.Drawing.Size(69, 21);
            this.InfinityButton.TabIndex = 9;
            this.InfinityButton.TabStop = true;
            this.InfinityButton.Text = "Infinity";
            this.InfinityButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Repeat";
            // 
            // MouseY
            // 
            this.MouseY.AutoSize = true;
            this.MouseY.Location = new System.Drawing.Point(37, 249);
            this.MouseY.Name = "MouseY";
            this.MouseY.Size = new System.Drawing.Size(67, 17);
            this.MouseY.TabIndex = 11;
            this.MouseY.Text = "Mouse Y:";
            // 
            // MouseX
            // 
            this.MouseX.AutoSize = true;
            this.MouseX.Location = new System.Drawing.Point(176, 249);
            this.MouseX.Name = "MouseX";
            this.MouseX.Size = new System.Drawing.Size(67, 17);
            this.MouseX.TabIndex = 12;
            this.MouseX.Text = "Mouse X:";
            // 
            // ClicksLabel
            // 
            this.ClicksLabel.AutoSize = true;
            this.ClicksLabel.Location = new System.Drawing.Point(304, 249);
            this.ClicksLabel.Name = "ClicksLabel";
            this.ClicksLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClicksLabel.Size = new System.Drawing.Size(48, 17);
            this.ClicksLabel.TabIndex = 13;
            this.ClicksLabel.Text = "Clicks:";
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(440, 275);
            this.Controls.Add(this.ClicksLabel);
            this.Controls.Add(this.MouseX);
            this.Controls.Add(this.MouseY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoClicker";
            this.Text = "AutoClicker - Off";
            this.Load += new System.EventHandler(this.AutoClicker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox IntervalsBox;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Options;
        private System.Windows.Forms.ComboBox ButtonSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RepeatButton;
        private System.Windows.Forms.RadioButton InfinityButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown RepeatNumber;
        private System.Windows.Forms.Label MouseY;
        private System.Windows.Forms.Label MouseX;
        private System.Windows.Forms.Label ClicksLabel;
    }
}

