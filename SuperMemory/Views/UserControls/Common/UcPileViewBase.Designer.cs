namespace SuperMemory.Views.UserControls.Common
{
    partial class UcPileViewBase
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
            this.lbPile = new System.Windows.Forms.Label();
            this.picbMark = new System.Windows.Forms.PictureBox();
            this.picbPile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbPile)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPile
            // 
            this.lbPile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPile.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPile.Location = new System.Drawing.Point(0, 0);
            this.lbPile.Name = "lbPile";
            this.lbPile.Size = new System.Drawing.Size(150, 150);
            this.lbPile.TabIndex = 1;
            this.lbPile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPile.Visible = false;
            this.lbPile.MouseLeave += new System.EventHandler(this.lbPile_MouseLeave);
            this.lbPile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbPile_MouseClick);
            this.lbPile.MouseEnter += new System.EventHandler(this.lbPile_MouseEnter);
            // 
            // picbMark
            // 
            this.picbMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picbMark.Location = new System.Drawing.Point(81, 83);
            this.picbMark.Name = "picbMark";
            this.picbMark.Size = new System.Drawing.Size(66, 64);
            this.picbMark.TabIndex = 4;
            this.picbMark.TabStop = false;
            this.picbMark.Visible = false;
            // 
            // picbPile
            // 
            this.picbPile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbPile.Location = new System.Drawing.Point(0, 0);
            this.picbPile.Name = "picbPile";
            this.picbPile.Size = new System.Drawing.Size(150, 150);
            this.picbPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbPile.TabIndex = 5;
            this.picbPile.TabStop = false;
            this.picbPile.Visible = false;
            this.picbPile.MouseLeave += new System.EventHandler(this.picbPile_MouseLeave);
            this.picbPile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbPile_MouseClick);
            this.picbPile.MouseEnter += new System.EventHandler(this.picbPile_MouseEnter);
            // 
            // UcPileViewBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.picbMark);
            this.Controls.Add(this.lbPile);
            this.Controls.Add(this.picbPile);
            this.Name = "UcPileViewBase";
            this.Load += new System.EventHandler(this.UcPileViewBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbPile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPile;
        private System.Windows.Forms.PictureBox picbMark;
        private System.Windows.Forms.PictureBox picbPile;
    }
}
