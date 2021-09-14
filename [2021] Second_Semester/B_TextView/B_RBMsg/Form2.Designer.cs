
namespace B_RBMsg
{
    partial class Form2
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
            this.gbOption1 = new System.Windows.Forms.GroupBox();
            this.rbOk = new System.Windows.Forms.RadioButton();
            this.rbOkCancel = new System.Windows.Forms.RadioButton();
            this.rbYesNo = new System.Windows.Forms.RadioButton();
            this.gbOption2 = new System.Windows.Forms.GroupBox();
            this.rbInformation = new System.Windows.Forms.RadioButton();
            this.rbQuestion = new System.Windows.Forms.RadioButton();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbOption1.SuspendLayout();
            this.gbOption2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOption1
            // 
            this.gbOption1.Controls.Add(this.rbOk);
            this.gbOption1.Controls.Add(this.rbOkCancel);
            this.gbOption1.Controls.Add(this.rbYesNo);
            this.gbOption1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbOption1.Location = new System.Drawing.Point(36, 33);
            this.gbOption1.Name = "gbOption1";
            this.gbOption1.Size = new System.Drawing.Size(182, 143);
            this.gbOption1.TabIndex = 0;
            this.gbOption1.TabStop = false;
            this.gbOption1.Text = "Type";
            // 
            // rbOk
            // 
            this.rbOk.AutoSize = true;
            this.rbOk.Location = new System.Drawing.Point(16, 31);
            this.rbOk.Name = "rbOk";
            this.rbOk.Size = new System.Drawing.Size(44, 21);
            this.rbOk.TabIndex = 2;
            this.rbOk.TabStop = true;
            this.rbOk.Text = "OK";
            this.rbOk.UseVisualStyleBackColor = true;
            // 
            // rbOkCancel
            // 
            this.rbOkCancel.AutoSize = true;
            this.rbOkCancel.Location = new System.Drawing.Point(16, 65);
            this.rbOkCancel.Name = "rbOkCancel";
            this.rbOkCancel.Size = new System.Drawing.Size(83, 21);
            this.rbOkCancel.TabIndex = 2;
            this.rbOkCancel.TabStop = true;
            this.rbOkCancel.Text = "OKCancel";
            this.rbOkCancel.UseVisualStyleBackColor = true;
            // 
            // rbYesNo
            // 
            this.rbYesNo.AutoSize = true;
            this.rbYesNo.Location = new System.Drawing.Point(16, 100);
            this.rbYesNo.Name = "rbYesNo";
            this.rbYesNo.Size = new System.Drawing.Size(64, 21);
            this.rbYesNo.TabIndex = 2;
            this.rbYesNo.TabStop = true;
            this.rbYesNo.Text = "YesNo";
            this.rbYesNo.UseVisualStyleBackColor = true;
            // 
            // gbOption2
            // 
            this.gbOption2.Controls.Add(this.rbInformation);
            this.gbOption2.Controls.Add(this.rbQuestion);
            this.gbOption2.Controls.Add(this.rbError);
            this.gbOption2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbOption2.Location = new System.Drawing.Point(262, 33);
            this.gbOption2.Name = "gbOption2";
            this.gbOption2.Size = new System.Drawing.Size(182, 143);
            this.gbOption2.TabIndex = 1;
            this.gbOption2.TabStop = false;
            this.gbOption2.Text = "Icon";
            // 
            // rbInformation
            // 
            this.rbInformation.AutoSize = true;
            this.rbInformation.Location = new System.Drawing.Point(15, 65);
            this.rbInformation.Name = "rbInformation";
            this.rbInformation.Size = new System.Drawing.Size(96, 21);
            this.rbInformation.TabIndex = 2;
            this.rbInformation.TabStop = true;
            this.rbInformation.Text = "Information";
            this.rbInformation.UseVisualStyleBackColor = true;
            // 
            // rbQuestion
            // 
            this.rbQuestion.AutoSize = true;
            this.rbQuestion.Location = new System.Drawing.Point(15, 100);
            this.rbQuestion.Name = "rbQuestion";
            this.rbQuestion.Size = new System.Drawing.Size(80, 21);
            this.rbQuestion.TabIndex = 2;
            this.rbQuestion.TabStop = true;
            this.rbQuestion.Text = "Question";
            this.rbQuestion.UseVisualStyleBackColor = true;
            // 
            // rbError
            // 
            this.rbError.AutoSize = true;
            this.rbError.Location = new System.Drawing.Point(15, 31);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(56, 21);
            this.rbError.TabIndex = 2;
            this.rbError.TabStop = true;
            this.rbError.Text = "Error";
            this.rbError.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Location = new System.Drawing.Point(368, 192);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(76, 36);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 249);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gbOption2);
            this.Controls.Add(this.gbOption1);
            this.Name = "Form2";
            this.Text = "메시지 박스 보기";
            this.gbOption1.ResumeLayout(false);
            this.gbOption1.PerformLayout();
            this.gbOption2.ResumeLayout(false);
            this.gbOption2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOption1;
        private System.Windows.Forms.RadioButton rbOk;
        private System.Windows.Forms.RadioButton rbOkCancel;
        private System.Windows.Forms.RadioButton rbYesNo;
        private System.Windows.Forms.GroupBox gbOption2;
        private System.Windows.Forms.RadioButton rbInformation;
        private System.Windows.Forms.RadioButton rbQuestion;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.Button btnShow;
    }
}

