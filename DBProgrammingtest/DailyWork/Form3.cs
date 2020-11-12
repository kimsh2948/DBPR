using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyWork
{
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3()
        {
            InitializeComponent();
            InitVariables();
        }
        public Form3(Form1 form)
        {
            InitializeComponent();
            form1 = form;
            this.buttonWorkModSave.Click += buttonWorkModSave_Click;
        }
        public void InitVariables()
        {

        }

        private void buttonWorkModSave_Click(object sender, EventArgs e)
        {
            ModWork();
        }
        
        public void ModWork()
        {
            int indexnum = form1.listViewWorkList.FocusedItem.Index-1;
            /*
            string maincategory = form1.listViewWorkList.Items[indexnum].SubItems[1].Text;
            string middlecategory = form1.listViewWorkList.Items[indexnum].SubItems[2].Text;
            string subcategory = form1.listViewWorkList.Items[indexnum].SubItems[3].Text;
            */
            var maincategory = comboBoxMainCateMod.Text;
            var middlecategory = comboBoxMiddleCateMod.Text;
            var subcategory = comboBoxSubCateMod.Text;
            string query = "UPDATE dailywork SET MainCategory = '" + maincategory + "', " +
                "'" + middlecategory + "', '" + subcategory + "' WHERE id = '"+indexnum+"'";
            if (maincategory == "대분류" || middlecategory == "중분류" || subcategory == "소분류")
            {
                MessageBox.Show("항목을 수정해 주세요");
            }
            else
            {
                DBManager.GetInstace().Update(query);
                this.Close();
            }
        }
    }
}
