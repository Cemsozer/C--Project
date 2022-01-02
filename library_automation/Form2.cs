using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_automation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        /*
dataGridView1.ColumnCount =8;
   dataGridView1.Columns[0].Name ="Id";
   dataGridView1.Columns[1].Name = "Adi";
   dataGridView1.Columns[2].Name = "Yazar";
   dataGridView1.Columns[3].Name = "Baskı Yılı";
   dataGridView1.Columns[4].Name = "Sayfa Sayısı";
   dataGridView1.Columns[5].Name = "Dil";
   dataGridView1.Columns[6].Name = "Yayın Evi";
   dataGridView1.Columns[7].Name = "Açıklama";
   dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
   string[] row = { "1", "Nutuk", "can celik","2012","300","TR","can yayinlari","hello world every body"};
   dataGridView1.Rows.Add(row);

*/
    }
}
