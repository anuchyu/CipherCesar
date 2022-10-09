using System;
using System.Text;
using System.Windows.Forms;

namespace CipherCesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string allCharacters = "абвгдеёжзийклмнопрстуфхцчшщъьэюя 0123456789";
        private void encoded_Click(object sender, EventArgs e)
        {
            textInCode.Text = Cipher(textInCode.Text);
        }
        public string Cipher(string inp)
        {
            StringBuilder code = new StringBuilder();
            string textIn = textInCode.Text;
            string textOut = stepCode.Text;
            int step = Convert.ToInt32(textOut);
            for ( int i = 0; i < textIn.Length; i++)
            {
                for (int j = 0; j < allCharacters.Length; j++)
                {
                    if (textIn[i] == allCharacters[j])
                    {
                        code.Append(allCharacters[j]);
                    }
                }
            }
            return code.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
