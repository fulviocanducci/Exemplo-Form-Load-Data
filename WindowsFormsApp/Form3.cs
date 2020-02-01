using DatabaseOrm.Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
   public partial class Form3 : Form
   {
      public Form3(BlazordatabaseContext DatabaseContext, int codigo)
      {
         InitializeComponent();
         this.DatabaseContext = DatabaseContext;
         Codigo = codigo;
      }

      public BlazordatabaseContext DatabaseContext { get; }
      public int Codigo { get; }

      private void Form3_Load(object sender, EventArgs e)
      {
         Peoples people = DatabaseContext?.Peoples.Find(Codigo);
         if (people != null)
         {
            TxtId.Text = people.Id.ToString();
            TxtName.Text = people.Name;
         }
      }

      private void BtnClose_Click(object sender, EventArgs e)
      {
         Close();         
      }

      private void BtnUpdate_Click(object sender, EventArgs e)
      {
         Peoples people = DatabaseContext?.Peoples.Find(Codigo);
         people.Name = TxtName.Text;
         DatabaseContext.SaveChanges();
         Close();
      }
   }
}
