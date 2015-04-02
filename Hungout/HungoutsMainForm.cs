using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hungout
{
    public partial class HungoutsMainForm : Form, IMessageFilter
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private HashSet<Control> controlsToMove = new HashSet<Control>();

        RootObject currentRootObject;

        public HungoutsMainForm()
        {
            Application.AddMessageFilter(this);

            controlsToMove.Add(this);
            controlsToMove.Add(this.titleLabel);//Add whatever controls here you want to move the form when it is clicked and dragged

            InitializeComponent();
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN &&
                 controlsToMove.Contains(Control.FromHandle(m.HWnd)))
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|JSON Files (.json)|*.json";
            openFileDialog1.FilterIndex = 2;

            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    HangoutsJSON hg = new HangoutsJSON();
                    hg.json = text;
                    currentRootObject = hg.parse();
                    conversationPicker.Items.AddRange(currentRootObject.conversation_state.ToArray());
                    conversationPicker.SelectedIndex = 0;

                }
                catch (IOException)
                {
                }
            }

        }

        private void conversationPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            messageListBox.Items.Clear();
            int index = conversationPicker.SelectedIndex;
            ConversationState cs = currentRootObject.conversation_state.ElementAt(index);
            messageListBox.Items.AddRange(cs.conversation_state.@event.ToArray());
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }


        }
    }
}
