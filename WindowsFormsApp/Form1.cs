using DatabaseOrm.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp
{
   public partial class Form1 : Form
   {
      protected BlazordatabaseContext DatabaseContext { get; }
      public Form1()
      {
         InitializeComponent();

         DbContextOptionsBuilder<BlazordatabaseContext> contextOptionsBuilder =
            new DbContextOptionsBuilder<BlazordatabaseContext>();
         contextOptionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BlazordatabaseConnectionString"].ConnectionString);

         DatabaseContext = new BlazordatabaseContext(contextOptionsBuilder.Options);
      }

      private void Form1_Load(object sender, EventArgs e)
      {
      }

      private void button1_Click(object sender, EventArgs e)
      {         
         Form2 form2 = new Form2(DatabaseContext);
         form2.ShowDialog();
      }
   }
}
