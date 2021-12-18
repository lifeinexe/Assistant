namespace Assistant
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.emailTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.messageTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sendButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 32);
            this.panel1.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(283, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(22, 22);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Баг-репорт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Нашли ошибку? Сообщите нам!";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameTextbox.ForeColor = System.Drawing.Color.Black;
            this.nameTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.nameTextbox.HintText = "";
            this.nameTextbox.isPassword = false;
            this.nameTextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.nameTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.nameTextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nameTextbox.LineThickness = 3;
            this.nameTextbox.Location = new System.Drawing.Point(13, 94);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(267, 44);
            this.nameTextbox.TabIndex = 4;
            this.nameTextbox.Text = "Ваше имя";
            this.nameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTextbox.ForeColor = System.Drawing.Color.Black;
            this.emailTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.emailTextbox.HintText = "";
            this.emailTextbox.isPassword = false;
            this.emailTextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.emailTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.emailTextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.emailTextbox.LineThickness = 3;
            this.emailTextbox.Location = new System.Drawing.Point(13, 159);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(267, 44);
            this.emailTextbox.TabIndex = 5;
            this.emailTextbox.Text = "Ваш EMail";
            this.emailTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // messageTextbox
            // 
            this.messageTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.messageTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.messageTextbox.ForeColor = System.Drawing.Color.Black;
            this.messageTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.messageTextbox.HintText = "";
            this.messageTextbox.isPassword = false;
            this.messageTextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.messageTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.messageTextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.messageTextbox.LineThickness = 3;
            this.messageTextbox.Location = new System.Drawing.Point(13, 225);
            this.messageTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.messageTextbox.Name = "messageTextbox";
            this.messageTextbox.Size = new System.Drawing.Size(267, 44);
            this.messageTextbox.TabIndex = 6;
            this.messageTextbox.Text = "Опишите ошибку";
            this.messageTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sendButton
            // 
            this.sendButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendButton.BorderRadius = 0;
            this.sendButton.ButtonText = "Отправить";
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.DisabledColor = System.Drawing.Color.Gray;
            this.sendButton.Iconcolor = System.Drawing.Color.Transparent;
            this.sendButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("sendButton.Iconimage")));
            this.sendButton.Iconimage_right = null;
            this.sendButton.Iconimage_right_Selected = null;
            this.sendButton.Iconimage_Selected = null;
            this.sendButton.IconMarginLeft = 0;
            this.sendButton.IconMarginRight = 0;
            this.sendButton.IconRightVisible = true;
            this.sendButton.IconRightZoom = 0D;
            this.sendButton.IconVisible = true;
            this.sendButton.IconZoom = 90D;
            this.sendButton.IsTab = false;
            this.sendButton.Location = new System.Drawing.Point(53, 291);
            this.sendButton.Name = "sendButton";
            this.sendButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.sendButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.sendButton.OnHoverTextColor = System.Drawing.Color.White;
            this.sendButton.selected = false;
            this.sendButton.Size = new System.Drawing.Size(211, 48);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Отправить";
            this.sendButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendButton.Textcolor = System.Drawing.Color.White;
            this.sendButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(308, 360);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox messageTextbox;
        private Bunifu.Framework.UI.BunifuFlatButton sendButton;
    }
}