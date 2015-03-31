using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hungout
{
    public partial class HungoutsMainForm : Form
    {
        RootObject currentRootObject;

        public HungoutsMainForm()
        {
            InitializeComponent();
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
    }
}
