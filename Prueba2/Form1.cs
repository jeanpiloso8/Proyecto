using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inicio();
        }

        public void inicio()
        {
            try
            {

                DataTable dt = new DataTable();
                foreach (DataGridViewColumn c in dgCanciones.Columns)
                    dt.Columns.Add(c.Name);
                dt.Rows.Add("brr", "pep", "bri-bri");
                dt.Rows.Add("fiu", "birip", "plop");
                dt.Rows.Add("cric-cric", "trri-trri", "cric-cric");
                dt.Rows.Add("brrah", "croac", "brrah");

                foreach (DataRow r in dt.Rows)
                    dgCanciones.Rows.Add(r.ItemArray);


            }
            catch (Exception ex)
            {

            }
           

        }

        private void dgCanciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indice = e.RowIndex;
                int col = e.ColumnIndex;

                for (int i = indice+1; i < dgCanciones.Rows.Count; i++)
                {
                  
                    lbresspuesta.Text = dgCanciones.Rows[i].Cells[col].Value.ToString();

                    Thread.Sleep(1000);
                    this.Update();
                }



            }
            catch (Exception ex)
            {

            }
            finally
            {
                Thread.Sleep(1000);
                this.Update();
                lbresspuesta.Text = "";
            }

        }
    }
}
