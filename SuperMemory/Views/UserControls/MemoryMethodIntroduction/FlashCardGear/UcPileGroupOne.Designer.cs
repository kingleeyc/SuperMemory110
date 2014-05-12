namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear
{
    partial class UcPileGroupOne
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
            this.ucPileView1 = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.UcPileView();
            this.SuspendLayout();
            // 
            // ucPileView1
            // 
            this.ucPileView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPileView1.Location = new System.Drawing.Point(0, 0);
            this.ucPileView1.Name = "ucPileView1";
            this.ucPileView1.PileData = null;
            this.ucPileView1.Size = new System.Drawing.Size(279, 325);
            this.ucPileView1.TabIndex = 0;
            // 
            // UcPileGroupOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucPileView1);
            this.Name = "UcPileGroupOne";
            this.Size = new System.Drawing.Size(279, 325);
            this.ResumeLayout(false);

        }

        #endregion

        private UcPileView ucPileView1;
    }
}
