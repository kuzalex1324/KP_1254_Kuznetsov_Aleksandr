using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сryptographer
{
    public partial class Form1 : Form
    {
        List<Encryptor> encryptors = new List<Encryptor>();
        public Form1()
        {
            InitializeComponent();
        }

        char IncrementSymbolCode(char symbolCode)
        {
            return (char)((int)symbolCode + 1);
        }
        char DecrementSymbolCode(char symbolCode)
        {
            return (char)((int)symbolCode - 1);
        }
        char ZeroSymbolCode(char symbolCode)
        {
            return symbolCode;
        }

        private void BTNAddCommand_Click(object sender, EventArgs e)
        {
            LBSelectedCommands.Items.Add(LBAvailableComands.SelectedItem.ToString());
        }

        private void BTNDeleteCommand_Click(object sender, EventArgs e)
        {
            LBSelectedCommands.Items.Remove(LBSelectedCommands.SelectedItem);
        }

        private void BTNUnShifr_Click(object sender, EventArgs e)
        {
            Decryptor decryptor = new Decryptor();
            TBDecryptedText.Text = decryptor.Decrypt(TBKey.Text, TBCiphertext.Text);
        }

        private void BTNShifr_Click(object sender, EventArgs e)
        {
            encryptors.Clear();
            TBKey.Text = string.Empty;
            TBCiphertext.Text = string.Empty;
            foreach (string functionName in LBSelectedCommands.Items)
            {
                switch (functionName)
                {
                    case "Increment (+1)":
                        encryptors.Add(new Encryptor(IncrementSymbolCode, "Increment", "I"));
                        TBKey.Text += "I";
                        break;
                    case "Decrement (-1)":
                        encryptors.Add(new Encryptor(DecrementSymbolCode, "Decrement", "D"));
                        TBKey.Text += "D";
                        break;
                    case "Zero (0)":
                        encryptors.Add(new Encryptor(ZeroSymbolCode, "Zero", "Z"));
                        TBKey.Text += "Z";
                        break;
                }
            }
            for (int i = 0; i < TBStartText.Text.Length; i++)
            {
                TBCiphertext.Text += encryptors[i % encryptors.Count].Encrypt(TBStartText.Text[i]);
            }
        }

        private void BTNUp_Click(object sender, EventArgs e)
        {
            string command = LBSelectedCommands.Items[LBSelectedCommands.SelectedIndex - 1].ToString();
            LBSelectedCommands.Items[LBSelectedCommands.SelectedIndex - 1] = LBSelectedCommands.Items[LBSelectedCommands.SelectedIndex];
            LBSelectedCommands.Items[LBSelectedCommands.SelectedIndex] = command;
            LBSelectedCommands.SelectedIndex -= 1;
        }

        private void BTNDown_Click(object sender, EventArgs e)
        {
            if (LBSelectedCommands.SelectedIndex != LBSelectedCommands.Items.Count - 1)
            {
                string command = LBSelectedCommands.Items[LBSelectedCommands.SelectedIndex + 1].ToString();
                LBSelectedCommands.Items[LBSelectedCommands.SelectedIndex + 1] = LBSelectedCommands.Items[LBSelectedCommands.SelectedIndex];
                LBSelectedCommands.Items[LBSelectedCommands.SelectedIndex] = command;
                LBSelectedCommands.SelectedIndex += 1;
            }

        }
    }
}
