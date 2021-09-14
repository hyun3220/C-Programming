
namespace B_Image
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picImg = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(12, 12);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(299, 165);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 0;
            this.picImg.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(171, 183);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(61, 30);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ImgList
            // 
            this.ImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList.ImageStream")));
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList.Images.SetKeyName(0, "01.jpg");
            this.ImgList.Images.SetKeyName(1, "02.JPG");
            this.ImgList.Images.SetKeyName(2, "03.jpg");
            this.ImgList.Images.SetKeyName(3, "04.jpeg");
            this.ImgList.Images.SetKeyName(4, "05.jpg");
            this.ImgList.Images.SetKeyName(5, "06.jpg");
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(104, 183);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 30);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "이전";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 225);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "그림 보기";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.Button btnBack;
    }
}

