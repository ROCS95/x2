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

namespace MonolithConect
{
    public partial class GuestInHouse : Form
    {
        private DataTable dt = new DataTable();
        private DataTable dt2 = new DataTable();
        public GuestInHouse()
        {
            InitializeComponent();
        }

        private void GuestInHouse_Load(object sender, EventArgs e)
        {
            AgregarDatos2();
            
            
        }

        private void Sort()
        {
            try
            {
            dataGridViewAcceso.Columns["Room"].DisplayIndex = 0;
            dataGridViewAcceso.Columns["Arrival"].DisplayIndex = 1;
            dataGridViewAcceso.Columns["Departure"].DisplayIndex = 2;
            dataGridViewAcceso.Columns["Name"].DisplayIndex = 3;
            dataGridViewAcceso.Columns["Surname"].DisplayIndex = 4;
            dataGridViewAcceso.Columns["Email"].DisplayIndex = 5; 
            dataGridViewSinAcceso.Columns["Room"].DisplayIndex = 0;
            dataGridViewSinAcceso.Columns["Arrival"].DisplayIndex = 1;
            dataGridViewSinAcceso.Columns["Departure"].DisplayIndex = 2;
            dataGridViewSinAcceso.Columns["Name"].DisplayIndex = 3;
            dataGridViewSinAcceso.Columns["Surname"].DisplayIndex = 4;
            dataGridViewSinAcceso.Columns["Email"].DisplayIndex = 5;
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine("Message :{0} ", ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Message :{0} ", ex.Message);
            }

        }

        private void AgregarDatos()
        {
            try
            {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"\\192.168.200.95\htdocs\ex_hotel\data.xml");
            dt = dataSet.Tables["GuestProfile"];
            dt2 = dataSet.Tables["RESERVATION_LINE"];
            dt.Merge(dt2);
            dataGridViewAcceso.DataSource = dt;
            Acceso();
            Sort();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Message :{0} ", ex.Message);

            }


        }

        private void AgregarDatos2()
        {
            try
            {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"\\192.168.200.95\htdocs\ex_hotel\data.xml");
            dt = dataSet.Tables["GuestProfile"];
            dt2 = dataSet.Tables["RESERVATION_LINE"];
            dt.Merge(dt2);
            dataGridViewSinAcceso.DataSource = dt;
            SinAcceso();
            AgregarDatos();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Message :{0} ", ex.Message);

            }

        }

        private void SinAcceso()
        {
            string[] data = new string[dataGridViewSinAcceso.ColumnCount];
            for(int i = 0; i < dataGridViewSinAcceso.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewSinAcceso.ColumnCount; j++)
                {
                    data[j] = (string)dataGridViewSinAcceso[j, i].Value;
                }
                if (data[7] != null)
                {
                    if (data[7].Contains("@"))
                    {
                         dataGridViewSinAcceso.Rows.RemoveAt(i);
                         i--;
                    }
                }
            }
            
        }

        private void Acceso()
        {
            string[] data = new string[dataGridViewAcceso.ColumnCount];
            for (int i = 0; i < dataGridViewAcceso.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewAcceso.ColumnCount; j++)
                {
                    data[j] = (string)dataGridViewAcceso[j, i].Value;
                }
                if (data[7] != null)
                {
                    if (!data[7].Contains("@"))
                    {
                        dataGridViewAcceso.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
    }
}
