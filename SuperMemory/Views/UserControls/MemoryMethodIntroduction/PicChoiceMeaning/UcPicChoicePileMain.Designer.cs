namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning
{
    partial class UcPicChoicePileMain
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnStartTrainning = new DevComponents.DotNetBar.ButtonX();
            this.ucGroupCountDownView = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning.UcGroupCountDownViewAlpha();
            this.ucPicChoicePileChoicePart = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning.UcPicChoicePileChoicePart();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Location = new System.Drawing.Point(945, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 41);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStartTrainning
            // 
            this.btnStartTrainning.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStartTrainning.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStartTrainning.Location = new System.Drawing.Point(31, 22);
            this.btnStartTrainning.Name = "btnStartTrainning";
            this.btnStartTrainning.Size = new System.Drawing.Size(108, 41);
            this.btnStartTrainning.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStartTrainning.TabIndex = 4;
            this.btnStartTrainning.Text = "开始";
            this.btnStartTrainning.Click += new System.EventHandler(this.btnStartTrainning_Click);
            // 
            // ucGroupCountDownView
            // 
            this.ucGroupCountDownView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucGroupCountDownView.Location = new System.Drawing.Point(42, 82);
            this.ucGroupCountDownView.Name = "ucGroupCountDownView";
            this.ucGroupCountDownView.Size = new System.Drawing.Size(97, 97);
            this.ucGroupCountDownView.TabIndex = 6;
            // 
            // ucPicChoicePileChoicePart
            // 
            this.ucPicChoicePileChoicePart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucPicChoicePileChoicePart.Location = new System.Drawing.Point(84, 82);
            this.ucPicChoicePileChoicePart.Name = "ucPicChoicePileChoicePart";
            this.ucPicChoicePileChoicePart.Size = new System.Drawing.Size(928, 612);
            this.ucPicChoicePileChoicePart.TabIndex = 3;
            // 
            // UcPicChoicePileMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucGroupCountDownView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStartTrainning);
            this.Controls.Add(this.ucPicChoicePileChoicePart);
            this.Name = "UcPicChoicePileMain";
            this.Size = new System.Drawing.Size(1084, 729);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnStartTrainning;
        private UcPicChoicePileChoicePart ucPicChoicePileChoicePart;
        private UcGroupCountDownViewAlpha ucGroupCountDownView;
    }
}
