using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1_palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\n Compruebe si una cadena es palíndromo o no:\n");

            string str1;
            bool tf;


            str1 = textBox1.Text;
            tf = IsPalindrome(str1);
            if (tf == true)
            {
                MessageBox.Show(" La palabra es Palindrome.\n");
            }
            else
            {
                MessageBox.Show(" La palabra no es Palindrome.\n");
            }

        }
        public static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }
    }
}

