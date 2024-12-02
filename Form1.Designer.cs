using RoundedForms;

namespace GUIDSwitcher
{
    partial class GUIDSwitcher
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReplaceGUIDButton = new RoundedForms.RoundImagedButton();
            this.SelectFolderButton = new RoundedForms.RoundImagedButton();
            this.OutputRectangle = new RoundedForms.RoundRectangle();
            this.SettingsButton = new RoundedForms.RoundImagedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(21, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "v. 0.12";
            // 
            // ReplaceGUIDButton
            // 
            this.ReplaceGUIDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ReplaceGUIDButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ReplaceGUIDButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReplaceGUIDButton.ForeColor = System.Drawing.Color.White;
            this.ReplaceGUIDButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ReplaceGUIDButton.HighlightForeColor = System.Drawing.Color.White;
            this.ReplaceGUIDButton.ImagePathLocation = "test.png";
            this.ReplaceGUIDButton.Location = new System.Drawing.Point(126, 8);
            this.ReplaceGUIDButton.Name = "ReplaceGUIDButton";
            this.ReplaceGUIDButton.NameTag = null;
            this.ReplaceGUIDButton.PressedColor = System.Drawing.Color.CornflowerBlue;
            this.ReplaceGUIDButton.PressedForeColor = System.Drawing.Color.White;
            this.ReplaceGUIDButton.RoundRadius = 8;
            this.ReplaceGUIDButton.Size = new System.Drawing.Size(112, 26);
            this.ReplaceGUIDButton.TabIndex = 4;
            this.ReplaceGUIDButton.Text = "Перебить GUID";
            this.ReplaceGUIDButton.TextStringAlignmentHorizontal = System.Drawing.StringAlignment.Far;
            this.ReplaceGUIDButton.TextStringAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.ReplaceGUIDButton.Click += new System.EventHandler(this.ReplaceGUIDButton_Click);
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.SelectFolderButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SelectFolderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelectFolderButton.ForeColor = System.Drawing.Color.White;
            this.SelectFolderButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SelectFolderButton.HighlightForeColor = System.Drawing.Color.White;
            this.SelectFolderButton.ImagePathLocation = "test.png";
            this.SelectFolderButton.Location = new System.Drawing.Point(8, 8);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.NameTag = null;
            this.SelectFolderButton.PressedColor = System.Drawing.Color.CornflowerBlue;
            this.SelectFolderButton.PressedForeColor = System.Drawing.Color.White;
            this.SelectFolderButton.RoundRadius = 8;
            this.SelectFolderButton.Size = new System.Drawing.Size(112, 26);
            this.SelectFolderButton.TabIndex = 2;
            this.SelectFolderButton.Text = "Выбрать папку";
            this.SelectFolderButton.TextStringAlignmentHorizontal = System.Drawing.StringAlignment.Far;
            this.SelectFolderButton.TextStringAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // OutputRectangle
            // 
            this.OutputRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.OutputRectangle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.OutputRectangle.ForeColor = System.Drawing.Color.Gainsboro;
            this.OutputRectangle.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.OutputRectangle.HighlightForeColor = System.Drawing.Color.White;
            this.OutputRectangle.Location = new System.Drawing.Point(8, 40);
            this.OutputRectangle.Name = "OutputRectangle";
            this.OutputRectangle.PressedColor = System.Drawing.Color.Red;
            this.OutputRectangle.PressedForeColor = System.Drawing.Color.White;
            this.OutputRectangle.RoundRadius = 8;
            this.OutputRectangle.Size = new System.Drawing.Size(263, 295);
            this.OutputRectangle.TabIndex = 3;
            this.OutputRectangle.TextStringAlignmentHorizontal = System.Drawing.StringAlignment.Near;
            this.OutputRectangle.TextStringAlignmentVertical = System.Drawing.StringAlignment.Near;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.SettingsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SettingsButton.HighlightForeColor = System.Drawing.Color.White;
            this.SettingsButton.ImagePathLocation = "test.png";
            this.SettingsButton.Location = new System.Drawing.Point(244, 8);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.NameTag = null;
            this.SettingsButton.PressedColor = System.Drawing.Color.CornflowerBlue;
            this.SettingsButton.PressedForeColor = System.Drawing.Color.White;
            this.SettingsButton.RoundRadius = 8;
            this.SettingsButton.Size = new System.Drawing.Size(27, 26);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.TextStringAlignmentHorizontal = System.Drawing.StringAlignment.Far;
            this.SettingsButton.TextStringAlignmentVertical = System.Drawing.StringAlignment.Center;
            // 
            // GUIDSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(281, 347);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReplaceGUIDButton);
            this.Controls.Add(this.SelectFolderButton);
            this.Controls.Add(this.OutputRectangle);
            this.Name = "GUIDSwitcher";
            this.Text = "GUIDSwitcher";
            this.Load += new System.EventHandler(this.GUIDSwitcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public RoundImagedButton SelectFolderButton;
        public RoundRectangle OutputRectangle;
        public RoundImagedButton ReplaceGUIDButton;
        private System.Windows.Forms.Label label1;
        public RoundImagedButton SettingsButton;
    }
}

