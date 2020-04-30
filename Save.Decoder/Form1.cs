using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace GrowtopiaHack
{//Wrong Decoder
    public partial class Form1 : MetroSuite.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
    

        public string savePath()
        {
            string result;
            try
            {
                RegistryKey registryKey;
                if (Environment.Is64BitOperatingSystem)
                {
                    registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                }
                else
                {
                    registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32);
                }
                try
                {
                    registryKey = registryKey.OpenSubKey("Software\\Growtopia", true);
                    string text = (string)registryKey.GetValue("path");
                    if (Directory.Exists(text))
                    {
                        if (File.Exists(text + "\\save.dat"))
                        {
                            string text2 = null;
                            File.Open(text + "\\save.dat", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                            using (FileStream fileStream = new FileStream(text + "\\save.dat", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                            {
                                using (StreamReader streamReader = new StreamReader(fileStream, Encoding.Default))
                                {
                                    text2 = streamReader.ReadToEnd();
                                }
                            }
                            if (text2.Contains("tankid_password") & text2.Contains("tankid_name"))
                            {
                                result = text + "\\save.dat";
                            }
                            else
                            {
                                result = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat";
                            }
                        }
                        else
                        {
                            result = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat";
                        }
                    }
                    else
                    {
                        result = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat";
                    }
                }
                catch
                {
                    result = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat";
                }
            }
            catch
            {
                result = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat";
            }
            return result;
        }

        public string GetGrowID()
        {
            string result;
            try
            {
                string text = null;
                File.Open(pathsave.Text , FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using (FileStream fileStream = new FileStream(this.pathsave.Text , FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream, Encoding.Default))
                    {
                        text = streamReader.ReadToEnd();
                    }
                }
                Regex regex = new Regex("[^\\w0-9]");
                string text2 = text.Replace("\0", " ");
                string text3 = regex.Replace(text2.Substring(text2.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
                {
                    ' '
                })[3], string.Empty);
                if (text3 == null)
                {
                    result = "Error [No GrowID]";
                }
                else
                {
                    result = text3;
                }
            }
            catch (Exception ex)
            {
                result = "Error [" + ex.Message + "]";
            }
            return result;
        }

        public string GetLastWorld()
        {
            string result;
            try
            {
                string text = null;
                File.Open(this.pathsave.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using (FileStream fileStream = new FileStream(this.pathsave.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream, Encoding.Default))
                    {
                        text = streamReader.ReadToEnd();
                    }
                }
                Regex regex = new Regex("[^\\w0-9]");
                string text2 = text.Replace("\0", " ");
                string text3 = regex.Replace(text2.Substring(text2.IndexOf("lastworld") + "lastworld".Length).Split(new char[]
                {
                    ' '
                })[3], string.Empty);
                if (text3 == null)
                {
                    result = "Error [No GrowID]";
                }
                else
                {
                    result = text3;
                }
            }
            catch (Exception ex)
            {
                result = "Error [" + ex.Message + "]";
            }
            return result;
        }
     


           

      

 


        private void button10_Click(object sender, EventArgs e)
        {

        }
        string text = "";
        private void button13_Click(object sender, EventArgs e)
        {
            string text = "";
            pathsave.Text = savePath();
            Thread.Sleep(100);
            try
            {
                string[] array = new pwDec().Func(GetPasswordBytes());
                foreach (string str in array)
                {
                    text = text + str + Environment.NewLine;
                }
            }
            catch
            {
            }
            richTextBox1.Text = "GrowID: " + GetGrowID()  + "\nLast World: " + GetLastWorld() + "\n\nPassword:\n" + text;
        }
        public byte[] GetPasswordBytes()
        {
            try
            {
                File.Open(pathsave.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using (FileStream stream = new FileStream(pathsave.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader streamReader = new StreamReader(stream, Encoding.Default))
                    {
                        return Encoding.Default.GetBytes(streamReader.ReadToEnd());
                    }
                }
            }
            catch
            {
                return null;
            }
        }
        string texta = "";
        private void button12_Click(object sender, EventArgs e)
        {
            string texta = "";
            try
            {
                string[] array = new pwDec().Func(GetPasswordBytes());
                foreach (string str in array)
                {
                    texta = texta + str + Environment.NewLine;
                }
            }
            catch
            {
            }
            richTextBox1.Text = "GrowID: " + GetGrowID() + "\nLast World: " + GetLastWorld() + "\n\nPasswords:\n" + texta;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog run = new OpenFileDialog();
            DialogResult result = run.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = run.FileName;
                pathsave.Text = file;
                string texta = "";
                try
                {
                    string[] array = new pwDec().Func(GetPasswordBytes());
                    foreach (string str in array)
                    {
                        texta = texta + str + Environment.NewLine;
                    }
                }
                catch
                {
                }
                richTextBox1.Text = "GrowID: " + GetGrowID() + "\nLast World: " + GetLastWorld() + "\n\nPasswords:\n" + texta;
            }
        }

        private void secoudToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void secondToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



      

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void pathsave_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void label26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void processlabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void main_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void rainbow1_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void rainbow2_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void rainbow3_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void end_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void label22_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void prefix_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void label17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void nsrainbow_CheckedChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void nlogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void hotkeys_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void main2_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVOVUEyuiE6KyDN-sKNDVPA");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void asdsd_Tick(object sender, EventArgs e)
        {

        }

        private void ChangeTitle_Tick(object sender, EventArgs e)
        {

        }
    }

}