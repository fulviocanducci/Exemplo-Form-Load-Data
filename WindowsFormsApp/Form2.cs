using DatabaseOrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp
{
   public partial class Form2 : Form
   {
      public Form2()
      {
         InitializeComponent();
      }

      public Form2(BlazordatabaseContext DatabaseContext)
      {
         InitializeComponent();
         this.DatabaseContext = DatabaseContext;
      }

      public BlazordatabaseContext DatabaseContext { get; }

      private void Form2_Load(object sender, EventArgs e)
      {
         LoadDataGridView();

         //DatabaseContext.Peoples.Add();
         //DatabaseContext.SaveChanges();

         //var p = DatabaseContext.Peoples.Find(1);
         //p.Name = "kkkkkkk";
         //DatabaseContext.SaveChanges();

         //DatabaseContext.Peoples.Remove(DatabaseContext.Peoples.Find(1));
         //DatabaseContext.SaveChanges();

      }

      private void LoadDataGridView()
      {
         dataGridView1.DataSource = DatabaseContext.Peoples.ToList();
      }

      private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out int codigo))
         {
            Form3 form3 = new Form3(DatabaseContext, codigo);
            form3.ShowDialog();
            LoadDataGridView();
         }
      }

      //private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
      //{
      //   object value = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
      //   MessageBox.Show(value.ToString());
      //}
   }
}
