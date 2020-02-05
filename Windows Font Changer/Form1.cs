using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Windows_Font_Changer
{
    public partial class Form1 : Form
    {
        readonly RegistryKey localMachineKey = Registry.LocalMachine;
        readonly string RegWay1 = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts";
        readonly string RegWay2 = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\FontSubstitutes";
        readonly string textRestart = "restart your computer to complete install";

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = btn2;
            btn2.Focus();
        }

        void btn1_Click(object sender, EventArgs e)
        {
            btn1.Enabled = false;
            btn1.Visible = false;
            btn2.Enabled = false;
            btn2.Visible = false;
            btnReset.Enabled = false;
            btnReset.Visible = false;
            label1.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(77)))));
            label1.Text = "enter font name WITHOUT ERRORS";
            btnCust.Enabled = true;
            btnCust.Visible = true;
            textBox1.Enabled = true;
            textBox1.Visible = true;
            label2.Text = "";
            btnCust.Focus();
        }
        void btnCust_Click(object sender, EventArgs e)
        {
            RegistryKey localMachineKey = Registry.LocalMachine.OpenSubKey(RegWay1, true);

            localMachineKey.SetValue("Segoe UI (TrueType)", "");
            localMachineKey.SetValue("Segoe UI Bold (TrueType)", "");
            localMachineKey.SetValue("Segoe UI Bold Italic (TrueType)", "");
            localMachineKey.SetValue("Segoe UI Italic (TrueType)", "");
            localMachineKey.SetValue("Segoe UI Light (TrueType)", "");
            localMachineKey.SetValue("Segoe UI Semibold (TrueType)", "");
            localMachineKey.SetValue("Segoe UI Symbol (TrueType)", "");

            RegistryKey localMachineKey2 = Registry.LocalMachine.OpenSubKey(RegWay2, true);

            localMachineKey2.SetValue("Segoe UI", textBox1.Text);
            textBox1.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(212)))), ((int)(((byte)(25)))));
            label2.Text = textRestart;
            btnReset.Enabled = true;
            btnReset.Visible = true;

            /*MessageBox.Show("");*/
        }

        void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            if (textBox1.Text == "Tahoma")
            {
                textBox1.Text = "";
            }
            label2.Text = "";
        }

        void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCust_Click(this, new EventArgs());
        }

        void btn2_Click(object sender, EventArgs e)
        {
            RegistryKey localMachineKey = Registry.LocalMachine.OpenSubKey(RegWay1, true);

            localMachineKey.SetValue("Segoe UI (TrueType)", "segoeui.ttf");
            localMachineKey.SetValue("Segoe UI Black (TrueType)", "seguibl.ttf");
            localMachineKey.SetValue("Segoe UI Black Italic (TrueType)", "seguibli.ttf");
            localMachineKey.SetValue("Segoe UI Bold (TrueType)", "segoeuib.ttf");
            localMachineKey.SetValue("Segoe UI Bold Italic (TrueType)", "segoeuiz.ttf");
            localMachineKey.SetValue("Segoe UI Emoji (TrueType)", "seguiemj.ttf");
            localMachineKey.SetValue("Segoe UI Historic (TrueType)", "seguihis.ttf");
            localMachineKey.SetValue("Segoe UI Italic (TrueType)", "segoeuii.ttf");
            localMachineKey.SetValue("Segoe UI Light (TrueType)", "segoeuil.ttf");
            localMachineKey.SetValue("Segoe UI Light Italic (TrueType)", "seguili.ttf");
            localMachineKey.SetValue("Segoe UI Semibold (TrueType)", "seguisb.ttf");
            localMachineKey.SetValue("Segoe UI Semibold Italic (TrueType)", "seguisbi.ttf");
            localMachineKey.SetValue("Segoe UI Semilight (TrueType)", "segoeuisl.ttf");
            localMachineKey.SetValue("Segoe UI Semilight Italic (TrueType)", "seguisli.ttf");
            localMachineKey.SetValue("Segoe UI Symbol (TrueType)", "seguisym.ttf");
            localMachineKey.SetValue("Segoe MDL2 Assets (TrueType)", "segmdl2.ttf");
            localMachineKey.SetValue("Segoe Print (TrueType)", "segoepr.ttf");
            localMachineKey.SetValue("Segoe Print Bold (TrueType)", "segoeprb.ttf");
            localMachineKey.SetValue("Segoe Script (TrueType)", "segoesc.ttf");
            localMachineKey.SetValue("Segoe Script Bold (TrueType)", "segoescb.ttf");
            label1.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(212)))), ((int)(((byte)(25)))));
            label1.Text = "default font has been installed";
            label2.Text = textRestart;
            btnReset.Enabled = true;
            btnReset.Visible = true;

            RegistryKey localMachineKey2 = Registry.LocalMachine.OpenSubKey(RegWay2, true);

            localMachineKey2.DeleteValue("Segoe UI");
        }

        void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/alcortazzo");
        }

        void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -t 0");
        }
        void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
