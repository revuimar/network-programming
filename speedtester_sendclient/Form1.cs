using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace speedtester_sendclient
{
    public delegate void writeMember();
    public partial class Form1 : Form
    {
        public delegate void writeMember();
        private static bool transmitting;
        public Form1()
        {
            InitializeComponent();
            transmitting = false;
            writeMember d = new writeMember(setWriter);
            d();
        }
        public void setWriter()
        {
            System.Console.SetOut(this.writer);
        }
        private static bool isAddressValid(string fullAdress)
        {
            String[] addressAndPort = fullAdress.Split(':');
            try
            {
                IPAddress a = IPAddress.Parse(addressAndPort[0]);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }
        private void add_adress_button_Click(object sender, EventArgs e)
        {
            string fullAddress = this.address_textbox.Text + ":" + this.port_selector.Value.ToString();
            if (!isAddressValid(fullAddress))
            {
                System.Windows.Forms.MessageBox.Show("This addres is incorrect!","Alert!");
                return;
            }
            if (this.address_list_combo.Items.Contains(fullAddress))
            {
                System.Windows.Forms.MessageBox.Show("This addres already exists!", "Alert!");
                return;
            }
            else
            {
                this.address_list_combo.Items.Add(fullAddress);
                this.address_list_combo.SelectedIndex = 0; //Set on 0 so combobox doesnt appear empty
            }
        }


        private void size_track_bar_Scroll(object sender, EventArgs e)
        {
            this.size_label.Text = this.size_track_bar.Value.ToString();
        }

        private async void transission_button_Click(object sender, EventArgs e)
        {
            
            if (transmitting)
            {
                
                this.transission_button.Text = "Start Transmission";
                Program.stoppedHandshake();
                Program.stopTransmission("UDP");
                Program.stopTransmission("TCP");
                transmitting = false;
                //bool stopped = await Program.stoppedHandshake();
                /*
                if (!stopped)
                {
                    Program.stopTransmission("UDP");
                    Program.stopTransmission("TCP");
                    transmitting = false;
                }*/
            }
            else
            {
                transmitting = true;
                if (this.address_list_combo.Items.Count == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Empty address list!", "Alert!");
                    return;
                }
                this.transission_button.Text = "Stop Transmission";
                int size = int.Parse(this.size_label.Text);
                List<string> fulladdress = new List<string>();
                foreach (var item in this.address_list_combo.Items)
                {
                    fulladdress.Add(item.ToString());
                }
                bool isNagle = !this.nagle_checkBox.Checked;
                await Program.startTransmission(size, fulladdress, isNagle);
                
                //transmitting = false;
            }
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            if (this.address_list_combo.Items.Count != 0)
                this.address_list_combo.Items.RemoveAt(this.address_list_combo.SelectedIndex);
            if(this.address_list_combo.Items.Count != 0)
                this.address_list_combo.SelectedIndex = 0;
        }

        private void del_all_button_Click(object sender, EventArgs e)
        {
            if (this.address_list_combo.Items.Count != 0)
                this.address_list_combo.Items.Clear();
        }
    }
}
