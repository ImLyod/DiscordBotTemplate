namespace DiscordBotTemplate
{
    partial class Bot
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
            this.Status_Label = new System.Windows.Forms.Label();
            this.Status_Panel = new System.Windows.Forms.Panel();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.Status_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_Label.Location = new System.Drawing.Point(101, 9);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(73, 25);
            this.Status_Label.TabIndex = 0;
            this.Status_Label.Text = "Status";
            // 
            // Status_Panel
            // 
            this.Status_Panel.Controls.Add(this.Status_Label);
            this.Status_Panel.Location = new System.Drawing.Point(12, 12);
            this.Status_Panel.Name = "Status_Panel";
            this.Status_Panel.Size = new System.Drawing.Size(274, 43);
            this.Status_Panel.TabIndex = 3;
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(12, 61);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(274, 41);
            this.Connect_Button.TabIndex = 2;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // Bot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 114);
            this.Controls.Add(this.Status_Panel);
            this.Controls.Add(this.Connect_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Bot";
            this.Text = "Discord Bot Template";
            this.Load += new System.EventHandler(this.Bot_Load);
            this.Status_Panel.ResumeLayout(false);
            this.Status_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.Panel Status_Panel;
        private System.Windows.Forms.Button Connect_Button;
    }
}

