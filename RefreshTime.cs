using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonolithConect
{
    public partial class RefreshTime : Form
    {
        private int refreshTime;
        public RefreshTime()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("El Tiempo de Recarga por defecto es de 5 minutos");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            String AllowedChars = @"^\d+$";
            if (isValid(AllowedChars, textBoxMinutos.Text))
            {
                if (isValid(AllowedChars, textBoxSegundos.Text))
                {
                    refreshTime = (Int32.Parse(textBoxMinutos.Text) * 60)+Int32.Parse(textBoxSegundos.Text);
                    guardar();
                    this.Close();
                }
                else
                {
                    refreshTime = (Int32.Parse(textBoxMinutos.Text) * 60);
                    guardar();
                    this.Close();
                }
                
            }
            else if(isValid(AllowedChars, textBoxSegundos.Text))
            {
                refreshTime = Int32.Parse(textBoxSegundos.Text);
                guardar();
                this.Close();
            }

        }

        private void guardar()
        {
            using (StreamWriter ip = new StreamWriter(Path.Combine("refreshTime.txt")))
            {
                ip.WriteLine(refreshTime);
            }
        }

        private bool isValid(string allowedChars, string text)
        {
            bool valid;

                if (Regex.IsMatch(text, allowedChars) && Int32.Parse(text) > -1)
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                }

            return valid;
        }

        private void RefreshTime_Load(object sender, EventArgs e)
        {
            string refresh = System.IO.File.ReadAllText("refreshTime.txt");
            refreshTime = Int32.Parse(refresh.Replace("\r\n", ""));
            textBoxSegundos.Text = refreshTime.ToString();
        }
    }
}
