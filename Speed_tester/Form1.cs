using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed_tester
{
    public partial class Form1 : Form
    {
        private static bool isListening;
        public enum fieldType
        {
            errorRate,
            loss,
            transSpeed,
            statsTime,
            transTime,
            totalDataSize,
            dataSize
        }
        public Form1()
        {
            InitializeComponent();
            isListening = false;
        }

        private void listen_button_Click(object sender, EventArgs e)
        {
            if (isListening)
            {
                Program.stopListeners();
                this.listen_button.Text = "Start Listening";
            }
            else
            {
                Int32 port = Int32.Parse(port_input_textBox.Text);
                Program.startListeners(port);
                this.listen_button.Text = "Stop Listening";
            }
            isListening = !isListening;
        }
        public void updateTextBox(string protocol,fieldType field,string value)
        {
            string txtBxName = protocol + "_" + field.ToString() + "_textBox";
            Control[] controls = this.Controls.Find(txtBxName, true);
            TextBox txtBox = controls[0] as TextBox;
            if (txtBox != null)
            {
                txtBox.Text = value;
            }
        }
    }
}
