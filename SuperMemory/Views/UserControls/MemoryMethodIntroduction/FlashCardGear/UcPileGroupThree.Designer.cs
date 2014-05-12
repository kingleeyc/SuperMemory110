namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear
{
    partial class UcPileGroupThree
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
            this.ucPileView2 = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.UcPileView();
            this.ucPileView3 = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.UcPileView();
            this.SuspendLayout();
            // 
            // ucPileView1
            // 
            this.ucPileView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ucPileView1.Location = new System.Drawing.Point(0, 3);
            this.ucPileView1.Name = "ucPileView1";
            this.ucPileView1.PileData = null;
            this.ucPileView1.Size = new System.Drawing.Size(271, 318);
            this.ucPileView1.TabIndex = 0;
            // 
            // ucPileView2
            // 
            this.ucPileView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPileView2.Location = new System.Drawing.Point(277, 3);
            this.ucPileView2.Name = "ucPileView2";
            this.ucPileView2.PileData = null;
            this.ucPileView2.Size = new System.Drawing.Size(271, 318);
            this.ucPileView2.TabIndex = 1;
            // 
            // ucPileView3
            // 
            this.ucPileView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPileView3.Location = new System.Drawing.Point(554, 3);
            this.ucPileView3.Name = "ucPileView3";
            this.ucPileView3.PileData = null;
            this.ucPileView3.Size = new System.Drawing.Size(271, 318);
            this.ucPileView3.TabIndex = 2;
            // 
            // UcPileGroupThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucPileView3);
            this.Controls.Add(this.ucPileView2);
            this.Controls.Add(this.ucPileView1);
            this.Name = "UcPileGroupThree";
            this.Size = new System.Drawing.Size(829, 325);
            this.ResumeLayout(false);

        }

        #endregion

        private UcPileView ucPileView1;
        private UcPileView ucPileView2;
        private UcPileView ucPileView3;
    }
}
