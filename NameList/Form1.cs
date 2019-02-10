using NameList.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (NameListDbContext db = new NameListDbContext())
            {
                personBindingSource.DataSource = db.Persons.ToList();
                departmentBindingSource.DataSource = db.Departments.ToList();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //【注意】Navigatorデフォルトの削除ボタンを使用すると一つ先のレコードを削除してしまうため使用不可
            //メッセージボックス表示
            DialogResult result = MessageBox.Show("削除してもいいですか？", "確認", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            int currentRow = 0;
            //DataGridViewの場合
            currentRow = (int)personDataGridView.CurrentRow.Cells[0].Value;
            int updateCount = 0;
            using (var db = new NameListDbContext())
            {
                try
                {
                    var item = db.Persons.SingleOrDefault(x => x.Id == currentRow);
                    if (item != null)
                    {
                        db.Persons.Remove(item);
                        updateCount = db.SaveChanges();
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    // 例外処理
                    ex.EntityValidationErrors.SelectMany(error => error.ValidationErrors).ToList()
                        .ForEach(item => Console.WriteLine("{0} - {1}", item.PropertyName, item.ErrorMessage));
                }
            }
            //DataGridViewの場合 表示上の削除
            personDataGridView.Rows.RemoveAt(personDataGridView.CurrentRow.Index);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int updateCount = 0;
            using (var db = new NameListDbContext())
            {
                try
                {
                    var currentPersonId = db.Persons.Max(a => a.personId);
                    var person = new Person()
                    {
                        personId = currentPersonId + 1,
                        personName = "前田",
                        mailAddress = "aa@aa.co.jp",
                        departmentId = 1,
                        phoneNumber = "090887654567",
                        detail = "",
                        createdDateTime = DateTime.Now,
                        updatedDateTime = DateTime.Now
                    };

                    db.Persons.Add(person);
                    updateCount = db.SaveChanges();

                    personBindingSource.DataSource = db.Persons.ToList();
                }
                catch (DbEntityValidationException ex)
                {
                    // 例外処理
                    var errorMessage = "";
                    ex.EntityValidationErrors.SelectMany(error => error.ValidationErrors).ToList()
                        .ForEach(model => errorMessage = errorMessage + model.PropertyName + " - " + model.ErrorMessage);
                    MessageBox.Show(errorMessage);
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var currentId = (int)personDataGridView.CurrentRow.Cells[0].Value;
            using (NameListDbContext db = new NameListDbContext())
            {
                new UpdateForm() { person = db.Persons.SingleOrDefault(a => a.Id == currentId) }.ShowDialog();
                personBindingSource.DataSource = db.Persons.ToList();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            using (var db = new NameListDbContext())
            {
                try
                {
                    var query = db.Persons.Where(a => a.personName.Contains(searchTb.Text));
                    this.personBindingSource.DataSource = query.ToList();
                }
                catch (DbEntityValidationException ex)
                {
                    // 例外処理
                    var errorMessage = "";
                    ex.EntityValidationErrors.SelectMany(error => error.ValidationErrors).ToList()
                        .ForEach(model => errorMessage = errorMessage + model.PropertyName + " - " + model.ErrorMessage);
                    MessageBox.Show(errorMessage);
                }
            }
        }
    }
}
