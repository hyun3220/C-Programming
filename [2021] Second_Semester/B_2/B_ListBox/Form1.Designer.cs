
namespace B_ListBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lbView2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(245, 12);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(190, 23);
            this.txtList.TabIndex = 1;
            this.txtList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtList_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(367, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 283);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(42, 15);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "결과 : ";
            // 
            // lbView2
            // 
            this.lbView2.ItemHeight = 15;
            this.lbView2.Location = new System.Drawing.Point(12, 12);
            this.lbView2.Name = "lbView2";
            this.lbView2.Size = new System.Drawing.Size(218, 259);
            this.lbView2.TabIndex = 0;
            this.lbView2.SelectedIndexChanged += new System.EventHandler(this.lbView2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 318);
            this.Controls.Add(this.lbView2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "리스트 추가";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lbView2;
    }
}

