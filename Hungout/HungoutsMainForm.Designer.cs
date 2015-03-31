namespace Hungout
{
    partial class HungoutsMainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.conversationPicker = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load JSON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // messageListBox
            // 
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 20;
            this.messageListBox.Location = new System.Drawing.Point(12, 18);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(727, 384);
            this.messageListBox.TabIndex = 3;
            // 
            // conversationPicker
            // 
            this.conversationPicker.FormattingEnabled = true;
            this.conversationPicker.Location = new System.Drawing.Point(13, 414);
            this.conversationPicker.Name = "conversationPicker";
            this.conversationPicker.Size = new System.Drawing.Size(607, 28);
            this.conversationPicker.TabIndex = 4;
            this.conversationPicker.SelectedIndexChanged += new System.EventHandler(this.conversationPicker_SelectedIndexChanged);
            // 
            // HungoutsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 463);
            this.Controls.Add(this.conversationPicker);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HungoutsMainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.ComboBox conversationPicker;
    }
}

