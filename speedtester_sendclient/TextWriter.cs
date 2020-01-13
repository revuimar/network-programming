using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace speedtester_sendclient
{
    public class TextBoxWriter : TextWriter
    {
        // The control where we will write text.
        private Control MyControl;
        public TextBoxWriter(Control control)
        {
            MyControl = control;
        }

        public override void Write(char value)
        {
            MyControl.Invoke(
                    new Action(() =>
                    {
                        MyControl.Text += value;
                    }));
        }

        public override void Write(string value)
        {
            MyControl.Text += value;
        }

        public override Encoding Encoding
        {
            get { return Encoding.Unicode; }
        }
    }
}
