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
    public partial class UpdateForm : Form
    {
        public Person person { get; set; }

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            int updateCount = 0;
            using (var db = new NameListDbContext())
            {
                try
                {
                    updateCount = db.SaveChanges();
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
            this.Close();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            personBindingSource.DataSource = person;
        }
    }
}
