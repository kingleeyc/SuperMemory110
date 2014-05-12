namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding
{
    partial class UcTranscodingPanelBase
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
            this.ucTranscodingPart = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding.UcTranscodingPart();
            this.ucGroupCountDownView = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning.UcGroupCountDownViewAlpha();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnStartTrainning = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // ucTranscodingPart
            // 
            this.ucTranscodingPart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucTranscodingPart.Location = new System.Drawing.Point(59, 229);
            this.ucTranscodingPart.Name = "ucTranscodingPart";
            this.ucTranscodingPart.Size = new System.Drawing.Size(960, 387);
            this.ucTranscodingPart.TabIndex = 0;
            // 
            // ucGroupCountDownView
            // 
            this.ucGroupCountDownView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucGroupCountDownView.Location = new System.Drawing.Point(68, 79);
            this.ucGroupCountDownView.Name = "ucGroupCountDownView";
            this.ucGroupCountDownView.Size = new System.Drawing.Size(97, 97);
            this.ucGroupCountDownView.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Location = new System.Drawing.Point(956, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 41);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStartTrainning
            // 
            this.btnStartTrainning.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStartTrainning.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStartTrainning.Location = new System.Drawing.Point(21, 20);
            this.btnStartTrainning.Name = "btnStartTrainning";
            this.btnStartTrainning.Size = new System.Drawing.Size(108, 41);
            this.btnStartTrainning.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStartTrainning.TabIndex = 7;
            this.btnStartTrainning.Text = "开始";
            this.btnStartTrainning.Click += new System.EventHandler(this.btnStartTrainning_Click);
            // 
            // UcTranscodingPanelBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucGroupCountDownView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStartTrainning);
            this.Controls.Add(this.ucTranscodingPart);
            this.Name = "UcTranscodingPanelBase";
            this.Size = new System.Drawing.Size(1084, 729);
            this.ResumeLayout(false);

        }

        #endregion

        private UcTranscodingPart ucTranscodingPart;
        private SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning.UcGroupCountDownViewAlpha ucGroupCountDownView;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnStartTrainning;

    }
}
