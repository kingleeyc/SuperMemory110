namespace SuperMemory.Views.Forms.DataMgr
{
    partial class FormPilesDataMgr
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
            this.ucPilesDataMgr = new SuperMemory.Views.UserControls.DataMgr.UcPilesDataMgr();
            this.SuspendLayout();
            // 
            // ucPilesDataMgr
            // 
            this.ucPilesDataMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPilesDataMgr.Location = new System.Drawing.Point(0, 0);
            this.ucPilesDataMgr.Name = "ucPilesDataMgr";
            this.ucPilesDataMgr.Size = new System.Drawing.Size(1060, 624);
            this.ucPilesDataMgr.TabIndex = 0;
            // 
            // FormPilesDataMgr
            // 
            this.ClientSize = new System.Drawing.Size(1060, 624);
            this.Controls.Add(this.ucPilesDataMgr);
            this.Name = "FormPilesDataMgr";
            this.TabText = "桩数据管理";
            this.Text = "桩数据管理";
            this.Load += new System.EventHandler(this.FormPilesDataMgr_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.DataMgr.UcPilesDataMgr ucPilesDataMgr;
    }
}
