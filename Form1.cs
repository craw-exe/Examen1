using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;

namespace Examen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aBRIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                dataGridView1.DataSource = Datos(filePath);
            }
        }

        private DataTable Datos(string filePath)
        {
            DataTable dt = new DataTable();
            string[] x = File.ReadAllLines(filePath);
            if (x.Length > 0)
            {
                string[] y = x[0].Split(',');

                foreach (string linea in y)
                {
                    dt.Columns.Add(linea);
                }

                for (int i = 0; i < x.Length; i++)
                {
                    string[] z = x[i].Split(',');
                    dt.Rows.Add(z);
                }
            }
            return dt;
        }


    }
}
