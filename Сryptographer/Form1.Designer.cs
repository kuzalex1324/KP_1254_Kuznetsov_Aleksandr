namespace Сryptographer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBStartText = new System.Windows.Forms.TextBox();
            this.LBAvailableComands = new System.Windows.Forms.ListBox();
            this.LBSelectedCommands = new System.Windows.Forms.ListBox();
            this.BTNAddCommand = new System.Windows.Forms.Button();
            this.BTNDeleteCommand = new System.Windows.Forms.Button();
            this.BTNShifr = new System.Windows.Forms.Button();
            this.TBCiphertext = new System.Windows.Forms.TextBox();
            this.TBKey = new System.Windows.Forms.TextBox();
            this.BTNUnShifr = new System.Windows.Forms.Button();
            this.TBDecryptedText = new System.Windows.Forms.TextBox();
            this.BTNUp = new System.Windows.Forms.Button();
            this.BTNDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBStartText
            // 
            this.TBStartText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TBStartText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.TBStartText.Font = new System.Drawing.Font("Comic Sans MS", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBStartText.Location = new System.Drawing.Point(88, 13);
            this.TBStartText.Margin = new System.Windows.Forms.Padding(4);
            this.TBStartText.Multiline = true;
            this.TBStartText.Name = "TBStartText";
            this.TBStartText.Size = new System.Drawing.Size(621, 54);
            this.TBStartText.TabIndex = 1;
            this.TBStartText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBAvailableComands
            // 
            this.LBAvailableComands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.LBAvailableComands.Font = new System.Drawing.Font("Comic Sans MS", 7.865546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBAvailableComands.FormattingEnabled = true;
            this.LBAvailableComands.ItemHeight = 18;
            this.LBAvailableComands.Items.AddRange(new object[] {
            "Increment (+1)",
            "Decrement (-1)",
            "Zero (0)"});
            this.LBAvailableComands.Location = new System.Drawing.Point(88, 92);
            this.LBAvailableComands.Margin = new System.Windows.Forms.Padding(4);
            this.LBAvailableComands.Name = "LBAvailableComands";
            this.LBAvailableComands.Size = new System.Drawing.Size(239, 184);
            this.LBAvailableComands.TabIndex = 3;
            // 
            // LBSelectedCommands
            // 
            this.LBSelectedCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.LBSelectedCommands.Font = new System.Drawing.Font("Comic Sans MS", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBSelectedCommands.FormattingEnabled = true;
            this.LBSelectedCommands.ItemHeight = 24;
            this.LBSelectedCommands.Location = new System.Drawing.Point(470, 92);
            this.LBSelectedCommands.Margin = new System.Windows.Forms.Padding(4);
            this.LBSelectedCommands.Name = "LBSelectedCommands";
            this.LBSelectedCommands.Size = new System.Drawing.Size(239, 196);
            this.LBSelectedCommands.TabIndex = 4;
            // 
            // BTNAddCommand
            // 
            this.BTNAddCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.BTNAddCommand.Location = new System.Drawing.Point(364, 138);
            this.BTNAddCommand.Margin = new System.Windows.Forms.Padding(4);
            this.BTNAddCommand.Name = "BTNAddCommand";
            this.BTNAddCommand.Size = new System.Drawing.Size(69, 39);
            this.BTNAddCommand.TabIndex = 6;
            this.BTNAddCommand.Text = "+";
            this.BTNAddCommand.UseVisualStyleBackColor = false;
            this.BTNAddCommand.Click += new System.EventHandler(this.BTNAddCommand_Click);
            // 
            // BTNDeleteCommand
            // 
            this.BTNDeleteCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.BTNDeleteCommand.Location = new System.Drawing.Point(364, 208);
            this.BTNDeleteCommand.Margin = new System.Windows.Forms.Padding(4);
            this.BTNDeleteCommand.Name = "BTNDeleteCommand";
            this.BTNDeleteCommand.Size = new System.Drawing.Size(69, 39);
            this.BTNDeleteCommand.TabIndex = 7;
            this.BTNDeleteCommand.Text = "-";
            this.BTNDeleteCommand.UseVisualStyleBackColor = false;
            this.BTNDeleteCommand.Click += new System.EventHandler(this.BTNDeleteCommand_Click);
            // 
            // BTNShifr
            // 
            this.BTNShifr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.BTNShifr.Font = new System.Drawing.Font("Comic Sans MS", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNShifr.Location = new System.Drawing.Point(119, 315);
            this.BTNShifr.Margin = new System.Windows.Forms.Padding(4);
            this.BTNShifr.Name = "BTNShifr";
            this.BTNShifr.Size = new System.Drawing.Size(565, 39);
            this.BTNShifr.TabIndex = 8;
            this.BTNShifr.Text = "Зашифровать";
            this.BTNShifr.UseVisualStyleBackColor = false;
            this.BTNShifr.Click += new System.EventHandler(this.BTNShifr_Click);
            // 
            // TBCiphertext
            // 
            this.TBCiphertext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.TBCiphertext.Font = new System.Drawing.Font("Comic Sans MS", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBCiphertext.Location = new System.Drawing.Point(88, 374);
            this.TBCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.TBCiphertext.Multiline = true;
            this.TBCiphertext.Name = "TBCiphertext";
            this.TBCiphertext.Size = new System.Drawing.Size(621, 54);
            this.TBCiphertext.TabIndex = 9;
            this.TBCiphertext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBKey
            // 
            this.TBKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.TBKey.Font = new System.Drawing.Font("Comic Sans MS", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBKey.Location = new System.Drawing.Point(88, 436);
            this.TBKey.Margin = new System.Windows.Forms.Padding(4);
            this.TBKey.Multiline = true;
            this.TBKey.Name = "TBKey";
            this.TBKey.Size = new System.Drawing.Size(621, 45);
            this.TBKey.TabIndex = 11;
            this.TBKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTNUnShifr
            // 
            this.BTNUnShifr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.BTNUnShifr.Font = new System.Drawing.Font("Comic Sans MS", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNUnShifr.Location = new System.Drawing.Point(119, 503);
            this.BTNUnShifr.Margin = new System.Windows.Forms.Padding(4);
            this.BTNUnShifr.Name = "BTNUnShifr";
            this.BTNUnShifr.Size = new System.Drawing.Size(565, 43);
            this.BTNUnShifr.TabIndex = 12;
            this.BTNUnShifr.Text = "Расшифровать";
            this.BTNUnShifr.UseVisualStyleBackColor = false;
            this.BTNUnShifr.Click += new System.EventHandler(this.BTNUnShifr_Click);
            // 
            // TBDecryptedText
            // 
            this.TBDecryptedText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.TBDecryptedText.Font = new System.Drawing.Font("Comic Sans MS", 7.865546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBDecryptedText.Location = new System.Drawing.Point(88, 565);
            this.TBDecryptedText.Margin = new System.Windows.Forms.Padding(4);
            this.TBDecryptedText.Multiline = true;
            this.TBDecryptedText.Name = "TBDecryptedText";
            this.TBDecryptedText.Size = new System.Drawing.Size(621, 54);
            this.TBDecryptedText.TabIndex = 13;
            this.TBDecryptedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTNUp
            // 
            this.BTNUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.BTNUp.Font = new System.Drawing.Font("Comic Sans MS", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNUp.Location = new System.Drawing.Point(721, 138);
            this.BTNUp.Margin = new System.Windows.Forms.Padding(4);
            this.BTNUp.Name = "BTNUp";
            this.BTNUp.Size = new System.Drawing.Size(69, 39);
            this.BTNUp.TabIndex = 14;
            this.BTNUp.Text = "Up";
            this.BTNUp.UseVisualStyleBackColor = false;
            this.BTNUp.Click += new System.EventHandler(this.BTNUp_Click);
            // 
            // BTNDown
            // 
            this.BTNDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.BTNDown.Font = new System.Drawing.Font("Comic Sans MS", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNDown.Location = new System.Drawing.Point(721, 208);
            this.BTNDown.Margin = new System.Windows.Forms.Padding(4);
            this.BTNDown.Name = "BTNDown";
            this.BTNDown.Size = new System.Drawing.Size(69, 39);
            this.BTNDown.TabIndex = 15;
            this.BTNDown.Text = "Down";
            this.BTNDown.UseVisualStyleBackColor = false;
            this.BTNDown.Click += new System.EventHandler(this.BTNDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(138)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(803, 668);
            this.Controls.Add(this.BTNDown);
            this.Controls.Add(this.BTNUp);
            this.Controls.Add(this.TBDecryptedText);
            this.Controls.Add(this.BTNUnShifr);
            this.Controls.Add(this.TBKey);
            this.Controls.Add(this.TBCiphertext);
            this.Controls.Add(this.BTNShifr);
            this.Controls.Add(this.BTNDeleteCommand);
            this.Controls.Add(this.BTNAddCommand);
            this.Controls.Add(this.LBSelectedCommands);
            this.Controls.Add(this.LBAvailableComands);
            this.Controls.Add(this.TBStartText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBStartText;
        private System.Windows.Forms.ListBox LBAvailableComands;
        private System.Windows.Forms.ListBox LBSelectedCommands;
        private System.Windows.Forms.Button BTNAddCommand;
        private System.Windows.Forms.Button BTNDeleteCommand;
        private System.Windows.Forms.Button BTNShifr;
        private System.Windows.Forms.TextBox TBCiphertext;
        private System.Windows.Forms.TextBox TBKey;
        private System.Windows.Forms.Button BTNUnShifr;
        private System.Windows.Forms.TextBox TBDecryptedText;
        private System.Windows.Forms.Button BTNUp;
        private System.Windows.Forms.Button BTNDown;
    }
}

