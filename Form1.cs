using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows;

namespace Crypt
{

    public partial class Form1 : Form
    {
      
      

        public Form1()
        {
            InitializeComponent();

        }

        private void buttonChose_Click(object sender, EventArgs e)
        {
            string path;
          

            if (openFileDialogChose.ShowDialog() == DialogResult.OK)
            {
                
               

                path = openFileDialogChose.FileName;
                
                FolderBrowserDialog folder = new FolderBrowserDialog();
            
                if( folder.ShowDialog()==DialogResult.OK)
                {
                    string pathTo = folder.SelectedPath;
                    pathTo += "\\"+ openFileDialogChose.SafeFileName;
                    using(FileStream fs = File.Create(pathTo)){} // without dispose
                    try
                    {
                        if (File.Exists(pathTo)) File.Delete(pathTo);
                        File.Copy(path, pathTo);

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                    
                }
                
            }
        }

        private void textBoxInteractive_TextChanged(object sender, EventArgs e)
        {

        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            FolderBrowserDialog folder = new FolderBrowserDialog();
          //@"C:\Users\user02\Desktop\folderCrypt\";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (folder.ShowDialog() == DialogResult.OK)
                    {
                        string pathCrypt = folder.SelectedPath;
                    try
                    {
                        FormPassword formEncrypt = new FormPassword();
                        formEncrypt.ShowDialog();//let you to complete a form
                        ClassCrypt.EncryptFileSalt(open.FileName, pathCrypt + open.SafeFileName, formEncrypt.password);
                        textBoxInteractive.Text += " File (" + open.FileName + ") was encrypted. Direction: " + pathCrypt + open.SafeFileName + "\n\r\n\r";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            FolderBrowserDialog folder = new FolderBrowserDialog();

           
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    string pathCrypt = folder.SelectedPath;
                    try
                    {
                        FormPassword formDecrypt = new FormPassword();
                        formDecrypt.ShowDialog();
                        ClassCrypt.DecryptFileSalt(open.FileName, pathCrypt + open.SafeFileName, formDecrypt.password);
                        textBoxInteractive.Text += " File (" + open.FileName + ") was decrypted. Direction: " + pathCrypt + open.SafeFileName + "\n\r\n\r";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            string address=  textBoxURL.Text;
            char[] add = address.ToCharArray();
            try{
            if (address.Length == 0 || add[0] == ' ') throw new DataException("There is no URL address");
        
            char [] format = new char[100];
            for( int i=add.Length-1; i>0; i--)
            {

                if (add[i] == '.') break;
                else  format[add.Length-1-i] =add[i]; 
            }
            format = format.Reverse().ToArray();
            string filter = new string(format);
            filter = filter.Replace("\0", string.Empty);
           
                WebClient client = new WebClient();

                    SaveFileDialog folder = new SaveFileDialog();
                    folder.Filter = "FILES (*." +filter+ ")|*." +filter;

                    if (folder.ShowDialog() == DialogResult.OK)
                    {
                        client.DownloadFile(address, folder.FileName);                        
                     }
                    textBoxInteractive.Text += address + "\n\r\n\r";
                    textBoxInteractive.Text += "File was saved to:" + folder.FileName + "\n\r\n\r"; 
            }
                catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
           
        }
    }
}
