namespace SuperMemory.Views.Forms.MemoryMethodIntroduction
{
    partial class FormTranscoding
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
            this.ucTranscodingSetting = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding.UcTranscodingSetting();
            this.SuspendLayout();
            // 
            // ucTranscodingSetting
            // 
            this.ucTranscodingSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucTranscodingSetting.Location = new System.Drawing.Point(106, 22);
            this.ucTranscodingSetting.Name = "ucTranscodingSetting";
            this.ucTranscodingSetting.Size = new System.Drawing.Size(559, 446);
            this.ucTranscodingSetting.TabIndex = 0;
            // 
            // FormTranscoding
            // 
            this.ClientSize = new System.Drawing.Size(769, 485);
            this.Controls.Add(this.ucTranscodingSetting);
            this.Name = "FormTranscoding";
            this.TabText = "编码转换";
            this.Text = "编码转换";
            this.Load += new System.EventHandler(this.FormTranscoding_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding.UcTranscodingSetting ucTranscodingSetting;
    }
}
