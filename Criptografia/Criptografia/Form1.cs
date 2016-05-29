using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_crip_Click(object sender, EventArgs e)
        {
            String phrase = txt_phrase.Text.ToString();
            phrase.ToCharArray();
            StringBuilder b = new StringBuilder();
            //move 3 positions foward
            for (int i = 0; i < phrase.Length; i++)
            {
                char a;
                int sum;
                a = phrase.ElementAt(i);
                a = (Char)(Convert.ToUInt16(a) + 3); 
                b.Append(a);
            }
            //invert order
            int begin = 0, end = (phrase.Length - 1);
            while (begin < end) {
                char aux;
                aux = b[begin];
                b[begin] = b[end];
                b[end] = aux;

                begin++;
                end--;
            }
            label.Text = b.ToString();
        }

        private void btn_dec_Click(object sender, EventArgs e)
        {
            String phrase = txt_phrase.Text.ToString();
            StringBuilder b = new StringBuilder();
            b.Append(phrase);
            phrase.ToCharArray();
            //invert order
            int begin = 0, end = (phrase.Length - 1);
            while (begin < end)
            {
                char aux;
                aux = b[begin];
                b[begin] = b[end];
                b[end] = aux;

                begin++;
                end--;
            }

            //move 3 positions foward
            for (int i = 0; i < phrase.Length; i++)
            {
                b[i] = (Char)(Convert.ToUInt16(b[i]) - 3);
            }
            label.Text = b.ToString();
        }
    }
}
