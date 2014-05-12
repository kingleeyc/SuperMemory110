namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning
{
    partial class UcPilePicView
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
            this.picbPile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbPile)).BeginInit();
            this.SuspendLayout();
            // 
            // picbPile
            // 
            this.picbPile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbPile.Location = new System.Drawing.Point(0, 0);
            this.picbPile.Name = "picbPile";
            this.picbPile.Size = new System.Drawing.Size(723, 529);
            this.picbPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbPile.TabIndex = 1;
            this.picbPile.TabStop = false;
            // 
            // UcPilePicView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picbPile);
            this.Name = "UcPilePicView";
            this.Size = new System.Drawing.Size(723, 529);
            ((System.ComponentModel.ISupportInitialize)(this.picbPile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbPile;
    }
}
