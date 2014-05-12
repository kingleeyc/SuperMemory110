namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear
{
    partial class UcPileView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbText = new System.Windows.Forms.Label();
            this.picbPile = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbPile)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbText);
            this.groupBox1.Controls.Add(this.picbPile);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbText
            // 
            this.lbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbText.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.Green;
            this.lbText.Location = new System.Drawing.Point(3, 17);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(265, 298);
            this.lbText.TabIndex = 2;
            this.lbText.Text = "label1";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbText.Visible = false;
            // 
            // picbPile
            // 
            this.picbPile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbPile.Location = new System.Drawing.Point(3, 17);
            this.picbPile.Name = "picbPile";
            this.picbPile.Size = new System.Drawing.Size(265, 298);
            this.picbPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbPile.TabIndex = 1;
            this.picbPile.TabStop = false;
            this.picbPile.Visible = false;
            // 
            // UcPileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcPileView";
            this.Size = new System.Drawing.Size(271, 318);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbPile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picbPile;
        private System.Windows.Forms.Label lbText;
    }
}
