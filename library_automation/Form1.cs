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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DragDrop dragdrop = new DragDrop();
        BtnProcess btnProcess = new BtnProcess();

        private Panel prevPanel;
        // --------------------------------------------      panelMeanger methods begin      ---------------------------------------------
        private void panelMenager(Panel pnl,string name="")
            {
            if(pnl != null)
            {
                prevPanel = pnl;
                exit_form.Visible = false;
                back_btn.Visible = true;
                pnl.Visible = true;
                pnl.BringToFront();
                if(name=="book")
                {
                    kitapToolStripMenuItem1.Visible = true;
                    /*
                    kitapEkleToolStripMenuItem1.Visible = true;
                    kitapListeleToolStripMenuItem1.Visible=true;
                    */
                    üyeToolStripMenuItem1.Visible = false;
                    emanetToolStripMenuItem.Visible = false;
                }
                else if(name=="user")
                {
                    kitapToolStripMenuItem1.Visible = false;
                    üyeToolStripMenuItem1.Visible = true;
                    emanetToolStripMenuItem.Visible = false;
                    /*
                    üyeEkleToolStripMenuItem.Visible = false;                
                    üyeListeleToolStripMenuItem.Visible = false;
                    */
                }
                else if(name=="deposit")
                {
                    kitapToolStripMenuItem1.Visible = false;
                    üyeToolStripMenuItem1.Visible = false;
                    emanetToolStripMenuItem.Visible = true;
                    /*
                    emanetEkleToolStripMenuItem.Visible = false;
                    emanetListeleToolStripMenuItem.Visible = false;
                    */
                }
            }
            else{
                prevPanel.Visible = false;
                exit_form.Visible = true;
                back_btn.Visible=false;
                kitapToolStripMenuItem1.Visible = true;
                üyeToolStripMenuItem1.Visible = true;
                emanetToolStripMenuItem.Visible = true;
                kitapEkleToolStripMenuItem1.Visible = true;
                kitapListeleToolStripMenuItem1.Visible = true;
                üyeEkleToolStripMenuItem.Visible = true;
                üyeListeleToolStripMenuItem.Visible = true;
                emanetEkleToolStripMenuItem.Visible=true;
                emanetListeleToolStripMenuItem.Visible = true;
                panelMenu.Visible = true;
                panelMenu.BringToFront();
            }
        }
        // --------------------------------------------      panelMeanger methods end      ---------------------------------------------
        // --------------------------------------------      load methods begin      ---------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            dragdrop.default_form(this);
        }
        // --------------------------------------------      load methods end      ---------------------------------------------
        // --------------------------------------------      Drag Drop mouse events methods begin      ---------------------------------------------
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragdrop.panel_Down(this);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            dragdrop.panel_Move(this);
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragdrop.panel_Up();
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            dragdrop.label_Down(this);
        }
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            dragdrop.label_Up();
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            dragdrop.label_Move(this);
        }
        // --------------------------------------------      Drag Drop mouse events methods end      ---------------------------------------------
        // --------------------------------------------      close and back btn mouse events methods begin      ---------------------------------------------
        private void exit_form_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            /* back_btn.Visible = false;
             addBookPanel.Visible = false;
             exit_form.Visible = true;*/
            /*
            kitapEkleToolStripMenuItem1.Visible = true;
            emanetToolStripMenuItem.Visible = true;
            üyeToolStripMenuItem1.Visible = true;
           */

            panelMenager(null);
        }
        // --------------------------------------------      close and back btn mouse events methods end      ---------------------------------------------
        // --------------------------------------------      book mouse events methods begin      ---------------------------------------------
        private void BookAdd_Click(object sender, EventArgs e)
        {
            //exit_form.Visible = false;
            //back_btn.Visible =true;
           // panelMenu.Visible = false;
            // addBookPanel.Visible= true;
            //addBookPanel.BringToFront();
            panelMenager(addBookPanel,"book");
           // emanetToolStripMenuItem.Visible = false;
            //üyeToolStripMenuItem1.Visible = false;

        }
        private void bookList_Click(object sender, EventArgs e)
        {
            btnProcess.dataGridViewBookLoad(dataGridViewBookList);
            panelMenager(panelBookList, "book");
        }
        private void kitapEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*  exit_form.Visible = false;
              back_btn.Visible = true;
              panelMenu.Visible = false;
              addBookPanel.Visible = true;
              addBookPanel.BringToFront();
              emanetToolStripMenuItem.Visible = false;
              üyeToolStripMenuItem1.Visible = false;
            */
            panelMenager(addBookPanel,"book");
        }
        private void kitapListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnProcess.dataGridViewBookLoad(dataGridViewBookList);
            panelMenager(panelBookList, "book");
        }
        private void addBookBtn_Click(object sender, EventArgs e)
        {
            string name, sheet, author, printYear, langugae, printHouse, comment;
            name = bookNameInput.Text.Trim();
            sheet = sheetNumberInput.Text.Trim();
            author = bookAuthorInput.Text.Trim();
            printYear = printYearInput.Text.Trim();
            langugae = bookLanguageInput.Text.Trim();
            printHouse = printHouseInput.Text.Trim();
            comment = commentInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(sheet) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(printYear) || string.IsNullOrWhiteSpace(langugae) || string.IsNullOrWhiteSpace(printHouse) || string.IsNullOrWhiteSpace(comment))
            {
                MessageBox.Show("Lüfen tüm analanları doldurunuz! ^_^", "Bu bir uyarıdır.", MessageBoxButtons.OK);
            }
            else
            {
                panelMenager(panelBookList, "book");
                btnProcess.dataGridViewBookLoad(dataGridViewBookList);
                btnProcess.dataGridViewBookAddData(name, sheet, author, printYear, langugae, printHouse, comment);
                panelMenager(panelBookList, "book");
                bookNameInput.Text = "";
                sheetNumberInput.Text = "";
                bookAuthorInput.Text = "";
                printYearInput.Text = "";
                bookLanguageInput.Text = "";
                printHouseInput.Text = "";
                commentInput.Text = "";
            }
        }
        // --------------------------------------------      book mouse events methods end      ---------------------------------------------
        // --------------------------------------------      deposit mouse events methods begin      ---------------------------------------------
        private void emanetEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenager(panelDepositBookAdd, "deposit");
        }
        private void emanetListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            btnProcess.dataGridViewDepositBookLoad(dataGridViewBookDepositList);
            panelMenager(panelDepositBookList, "deposit");
        }
        private void addDeposit_Click(object sender, EventArgs e)
        {
            panelMenager(panelDepositBookAdd, "deposit");
        }
        private void depositList_Click(object sender, EventArgs e)
        {
            btnProcess.dataGridViewDepositBookLoad(dataGridViewBookDepositList);
            panelMenager(panelDepositBookList, "deposit");
        }
        private void giveDepositBookBtn_Click(object sender, EventArgs e)
        {
            string userId, bookId, backTakeDate, depositeNote;
            userId = userNoInput.Text.Trim();
            bookId = bookNoInput.Text.Trim();
            backTakeDate = takeBackInput.Text.Trim();
            depositeNote = depositNotInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(bookId) || string.IsNullOrWhiteSpace(backTakeDate) || string.IsNullOrWhiteSpace(depositeNote))
            {
                MessageBox.Show("Lüfen tüm analanları doldurunuz! ^_^", "Bu bir uyarıdır.", MessageBoxButtons.OK);
            }
            else
            {
                btnProcess.dataGridViewDepositBookLoad(dataGridViewBookDepositList);
                btnProcess.dataGridViewDepositBookAddData(userId, bookId, backTakeDate, depositeNote);
                panelMenager(panelDepositBookList, "deposit");
                userNoInput.Text = "";
                bookNoInput.Text = "";
                takeBackInput.Text = "";
                depositNotInput.Text = "";
            }
        }
        // --------------------------------------------      deposit mouse events methods end      ---------------------------------------------
        // --------------------------------------------      user mouse events methods begin      ---------------------------------------------
        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenager(panelUserAdd, "user");
        }
        private void üyeListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnProcess.dataGridViewUserLoad(dataGridViewUserList);
            panelMenager(panelUserList, "user");
        }
        private void userAdd_Click_1(object sender, EventArgs e)
        {
            panelMenager(panelUserAdd,"user");
        }
        private void userList_Click(object sender, EventArgs e)
        {
            btnProcess.dataGridViewUserLoad(dataGridViewUserList);
            panelMenager(panelUserList, "user");
        }
        private void userAddBtn_Click(object sender, EventArgs e)
        {
            string name, surname, tel, mail, adress;
            name = userNameInput.Text.Trim();
            surname = userSurnameInput.Text.Trim();
            tel = userTelInput.Text.Trim();
            mail = userMailInput.Text.Trim();
            adress = userAdressInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(tel) || string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(adress))
            {
                MessageBox.Show("Lüfen tüm analanları doldurunuz! ^_^", "Bu bir uyarıdır.", MessageBoxButtons.OK);
            }
            else
            {
               btnProcess.dataGridViewUserLoad(dataGridViewUserList);
               btnProcess.dataGridViewUserAddData(name, surname, tel, mail, adress);
                panelMenager(panelUserList, "user");
                userAdressInput.Text = "";
                userMailInput.Text = "";
                userSurnameInput.Text = "";
                userTelInput.Text = "";
                userNameInput.Text = "";
            }
        }
        // --------------------------------------------      user mouse events methods end      ---------------------------------------------
    }
}
