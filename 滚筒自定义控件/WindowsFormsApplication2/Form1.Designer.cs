namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl11 = new WindowsFormsControlLibrary2.UserControl1();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Angle = 21966F;
            this.userControl11.Location = new System.Drawing.Point(33, 93);
            this.userControl11.Margin = new System.Windows.Forms.Padding(5);
            this.userControl11.Name = "userControl11";
            this.userControl11.RotateSpd = 15F;
            this.userControl11.RotateState = WindowsFormsControlLibrary2.ROTATE_STATE.ForwardRotating;
            this.userControl11.Size = new System.Drawing.Size(587, 575);
            this.userControl11.TabIndex = 0;
            this.userControl11.WaterLevel = 54.90000000000051D;
            this.userControl11.WaterState = WindowsFormsControlLibrary2.WATER_STATE.Stop;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl11);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary2.UserControl1 userControl11;
        private System.Windows.Forms.Label label1;
    }
}

