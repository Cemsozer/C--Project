using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_automation
{
    internal class BtnProcess
    {
        DataGridView _dgrw_book, _dgrw_user, _dgrw_deposit;
        String date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        public void dataGridViewBookLoad(DataGridView dgrw)
        {
            _dgrw_book = dgrw;
            dgrw.ColumnCount = 9;
            dgrw.Columns[0].Name = "Id";
            dgrw.Columns[1].Name = "İşlem Tarihi";
            dgrw.Columns[2].Name = "Adı";
            dgrw.Columns[3].Name = "Yazarı";
            dgrw.Columns[4].Name = "Baskı Yılı";
            dgrw.Columns[5].Name = "Sayfa Sayısı";
            dgrw.Columns[6].Name = "Dil";
            dgrw.Columns[7].Name = "Yayın Evi";
            dgrw.Columns[8].Name = "Açıklama";
            dgrw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrw.Dock = DockStyle.Fill;
        }
        public void dataGridViewBookAddData(string name, string sheet, string author, string printYear, string langugae, string printHouse, string comment)
        {
            int idCount = _dgrw_book.RowCount - 1;
            {
                string[] data = { idCount.ToString(),date, name, author, printYear, sheet, langugae, printHouse, comment };
                _dgrw_book.Rows.Add(data);
            }
        }
        public void dataGridViewUserLoad(DataGridView dgrw)
        {
            _dgrw_user = dgrw;
            dgrw.ColumnCount = 7;
            dgrw.Columns[0].Name = "Id";
            dgrw.Columns[1].Name = "İşlem Tarihi";
            dgrw.Columns[2].Name = "Adı";
            dgrw.Columns[3].Name = "Soyadı";
            dgrw.Columns[4].Name = "Telofonu";
            dgrw.Columns[5].Name = "E-Posta";
            dgrw.Columns[6].Name = "Adres";
            dgrw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrw.Dock = DockStyle.Fill;
        }
        public void dataGridViewUserAddData(string name, string surname, string tel, string mail, string adress)
        {
            int idCount = _dgrw_user.RowCount - 1;
            {
                string[] data = { idCount.ToString(),date, name,surname,tel,mail,adress};
                _dgrw_user.Rows.Add(data);
            }
        }
        public void dataGridViewDepositBookLoad(DataGridView dgrw)
        {
            _dgrw_deposit = dgrw;
            dgrw.ColumnCount = 7;
            dgrw.Columns[0].Name = "Id";
            dgrw.Columns[1].Name = "İşlem Tarihi";
            dgrw.Columns[2].Name = "Üye No";
            dgrw.Columns[3].Name = "Kitap No";
            dgrw.Columns[4].Name = "Geri Teslim Tarihi";
            dgrw.Columns[5].Name = "Emanet Notu";
            dgrw.Columns[6].Name = "Durum";
            dgrw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrw.Dock = DockStyle.Fill;
        }
        public void dataGridViewDepositBookAddData(string userId, string bookId, string backTakeDate, string depositeNote)
        {
            int idCount = _dgrw_deposit.RowCount - 1;
            {
                string[] data = { idCount.ToString(), date, userId, bookId, backTakeDate, depositeNote,"-"};
                _dgrw_deposit.Rows.Add(data);
            }
        }
    }
}
