namespace SuperMemory.Views.Forms.DataMgr
{
    partial class FormNewPileType
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
            this.ucNewPileType1 = new SuperMemory.Views.UserControls.DataMgr.UcNewPileType();
            this.SuspendLayout();
            // 
            // ucNewPileType1
            // 
            this.ucNewPileType1.Location = new System.Drawing.Point(12, 12);
            this.ucNewPileType1.Name = "ucNewPileType1";
            this.ucNewPileType1.Size = new System.Drawing.Size(332, 114);
            this.ucNewPileType1.TabIndex = 0;
            // 
            // FormNewPileType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 130);
            this.Controls.Add(this.ucNewPileType1);
            this.Name = "FormNewPileType";
            this.Text = "新建桩类别";
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.DataMgr.UcNewPileType ucNewPileType1;
    }
}