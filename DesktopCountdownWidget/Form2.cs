using System;
using System.IO;
using System.Windows.Forms;

namespace DesktopCountdownWidget
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void TextColorButton_Click(object sender, EventArgs e)
        {
            ColorPicker.ShowDialog();
            StreamWriter sw = new StreamWriter("config.ini");
            sw.WriteLine("test"+ColorPicker.Color.R);
            sw.Close();
        }
    }
}
