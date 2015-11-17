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

namespace WindowsFormsApplication1
{
    public partial class AesForm : Form
    {
        public AesForm()
        {
            InitializeComponent();
        }

        private string _fnKey;
        private string _fnInput;
        private string _fnOutput;
        private void buttonEncrypt_Click(object sender, EventArgs ev)
        {
            byte[] messageByte = null;
            byte[] keyByte = null;
            BinaryWriter chiperStream = null;
            try
            {
                FileInfo fileKey = new FileInfo(_fnKey);
                FileInfo fileMessage = new FileInfo(_fnInput);
                chiperStream = new BinaryWriter(File.Open(_fnOutput, FileMode.OpenOrCreate));

                //ЧТЕНИЕ
                BinaryReader keyStream = new BinaryReader(File.Open(_fnKey, FileMode.Open));
                keyByte = new byte[(int) fileKey.Length];
                keyStream.Read(keyByte, 0, (int) fileKey.Length);

                BinaryReader messageStream = new BinaryReader(File.Open(_fnInput, FileMode.Open));
                messageByte = new byte[(int) fileMessage.Length];
                messageStream.Read(messageByte, 0, (int) fileMessage.Length);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.Exit();
            }
            //ШИФРОВАНИЕ
            if (messageByte != null && keyByte != null)
            {
                var chiperByte = MyAES.encrypt(messageByte, keyByte);
                chiperStream.Write(chiperByte);
                MessageBox.Show("File was encrypted successfull!");
                Application.Exit();
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            byte[] messageByte = null;
            byte[] keyByte = null;
            BinaryWriter chiperStream = null;
            try
            {
                FileInfo fileKey = new FileInfo(_fnKey);
                FileInfo fileMessage = new FileInfo(_fnInput);
                chiperStream = new BinaryWriter(File.Open(_fnOutput, FileMode.OpenOrCreate));

                //ЧТЕНИЕ
                BinaryReader keyStream = new BinaryReader(File.Open(_fnKey, FileMode.Open));
                keyByte = new byte[(int) fileKey.Length];
                keyStream.Read(keyByte, 0, (int) fileKey.Length);

                BinaryReader messageStream = new BinaryReader(File.Open(_fnInput, FileMode.Open));
                messageByte = new byte[(int) fileMessage.Length];
                messageStream.Read(messageByte, 0, (int) fileMessage.Length);
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
                Application.Exit();
            }
            //ДЕШИФРОВАНИЕ
            if (messageByte != null && keyByte != null)
            {
                var chiperByte = MyAES.decrypt(messageByte, keyByte);
                chiperStream.Write(chiperByte);
                MessageBox.Show("File was decrypted successfull!");
                Application.Exit();
            }
        }

        private void buttonOpenKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            _fnKey = openFileDialog1.FileName;
            KeyFile.Text = _fnKey;

        }

        private void buttonOpenInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            _fnInput = openFileDialog1.FileName;
            InputFile.Text = _fnInput;
        }

        private void buttonOpenOutput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            _fnOutput = openFileDialog1.FileName;
            OutputFile.Text = _fnOutput;
        }
    }
}
