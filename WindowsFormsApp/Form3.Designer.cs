namespace WindowsFormsApp
{
   partial class Form3
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.TxtId = new System.Windows.Forms.TextBox();
         this.TxtName = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.BtnUpdate = new System.Windows.Forms.Button();
         this.BtnClose = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // TxtId
         // 
         this.TxtId.Location = new System.Drawing.Point(12, 30);
         this.TxtId.Name = "TxtId";
         this.TxtId.Size = new System.Drawing.Size(100, 20);
         this.TxtId.TabIndex = 0;
         // 
         // TxtName
         // 
         this.TxtName.Location = new System.Drawing.Point(12, 81);
         this.TxtName.Name = "TxtName";
         this.TxtName.Size = new System.Drawing.Size(440, 20);
         this.TxtName.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 11);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(16, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Id";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 62);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(35, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "Nome";
         // 
         // BtnUpdate
         // 
         this.BtnUpdate.Location = new System.Drawing.Point(15, 120);
         this.BtnUpdate.Name = "BtnUpdate";
         this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
         this.BtnUpdate.TabIndex = 4;
         this.BtnUpdate.Text = "Alterar";
         this.BtnUpdate.UseVisualStyleBackColor = true;
         this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
         // 
         // BtnClose
         // 
         this.BtnClose.Location = new System.Drawing.Point(377, 120);
         this.BtnClose.Name = "BtnClose";
         this.BtnClose.Size = new System.Drawing.Size(75, 23);
         this.BtnClose.TabIndex = 5;
         this.BtnClose.Text = "Fechar";
         this.BtnClose.UseVisualStyleBackColor = true;
         this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
         // 
         // Form3
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(462, 153);
         this.Controls.Add(this.BtnClose);
         this.Controls.Add(this.BtnUpdate);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.TxtName);
         this.Controls.Add(this.TxtId);
         this.Name = "Form3";
         this.Text = "Form3";
         this.Load += new System.EventHandler(this.Form3_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnClose;
    }
}