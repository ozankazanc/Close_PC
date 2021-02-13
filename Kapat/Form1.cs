using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapat
{
    public partial class Form1 : Form
    {
        private readonly Process _kapat= new Process();
        private string _command;
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 6; i++)
                cbTime.Items.Add(i);

            cbTime.SelectedItem = cbTime.Items[0];
        }
        private string Hour(string hour)
        {
            int _hour = Convert.ToInt32(hour.ToString()) * 3600;
            return _hour.ToString();
        }
        private void RunCommand(string command)
        {
            try
            {
                _kapat.StartInfo.FileName = "cmd.exe";
                _kapat.StartInfo.Arguments = command;
                _kapat.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                _kapat.Start();
                _kapat.WaitForExit();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnOkey_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txTime.Text))
                {
                    _command = $"/C shutdown -s -f -t {txTime.Text}"; // textboxtan değer girilirse combobox seçimi es geçilir.
                }
                else
                {
                    _command = $"/C shutdown -s -f -t {Hour(hour: cbTime.SelectedItem.ToString())}";
                }
                RunCommand(command: _command);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _command = "/C shutdown -a";
            RunCommand(command: _command);
        }
        private void CbTime_Click(object sender, EventArgs e)
        {
            cbTime.DroppedDown = true;
        }

        private void BtnFixBug_Click(object sender, EventArgs e)
        {
            _command = "/C shutdown /a";
            RunCommand(command: _command);
        }
    }
}
