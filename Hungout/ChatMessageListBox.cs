using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hungout
{
    class ChatMessageListBox : ListBox
    {
        private Button button1;


        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.Graphics.DrawLine(Pens.DarkGray, e.Bounds.X, e.Bounds.Y,
                        e.Bounds.X + e.Bounds.Width, e.Bounds.Y);
           // base.OnDrawItem(e);
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.ResumeLayout(false);

        }
    }
}
