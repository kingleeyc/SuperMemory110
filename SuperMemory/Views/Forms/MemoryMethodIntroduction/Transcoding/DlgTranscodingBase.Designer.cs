namespace SuperMemory.Views.Forms.MemoryMethodIntroduction.Transcoding
{
    partial class DlgTranscodingBase
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
            this.ucTranscodingPanelBase = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding.UcTranscodingPanelBase();
            this.SuspendLayout();
            // 
            // ucTranscodingPanelBase
            // 
            this.ucTranscodingPanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTranscodingPanelBase.Location = new System.Drawing.Point(0, 0);
            this.ucTranscodingPanelBase.Name = "ucTranscodingPanelBase";
            this.ucTranscodingPanelBase.Size = new System.Drawing.Size(1135, 696);
            this.ucTranscodingPanelBase.TabIndex = 0;
            // 
            // DlgTranscodingBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 696);
            this.Controls.Add(this.ucTranscodingPanelBase);
            this.Name = "DlgTranscodingBase";
            this.ShowInTaskbar = false;
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DlgPic2Num_Load);
            this.Controls.SetChildIndex(this.ucTranscodingPanelBase, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding.UcTranscodingPanelBase ucTranscodingPanelBase;
    }
}