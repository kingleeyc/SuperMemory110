namespace SuperMemory.Views.Forms.MemoryMethodIntroduction
{
    partial class FormPicChoiceMeaning
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
            this.ucPicChoiceMeaningSetting = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning.UcPicChoiceMeaningSetting();
            this.SuspendLayout();
            // 
            // ucPicChoiceMeaningSetting
            // 
            this.ucPicChoiceMeaningSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucPicChoiceMeaningSetting.Location = new System.Drawing.Point(101, 12);
            this.ucPicChoiceMeaningSetting.Name = "ucPicChoiceMeaningSetting";
            this.ucPicChoiceMeaningSetting.Size = new System.Drawing.Size(568, 454);
            this.ucPicChoiceMeaningSetting.TabIndex = 0;
            // 
            // FormPicChoiceMeaning
            // 
            this.ClientSize = new System.Drawing.Size(781, 487);
            this.Controls.Add(this.ucPicChoiceMeaningSetting);
            this.Name = "FormPicChoiceMeaning";
            this.TabText = "看图选义";
            this.Text = "看图选义";
            this.Load += new System.EventHandler(this.FormPicChoiceMeaning_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning.UcPicChoiceMeaningSetting ucPicChoiceMeaningSetting;
    }
}
