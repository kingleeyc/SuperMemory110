namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayProgress
{
    partial class UcTraningProgresser
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
            this.proBarTranning = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // proBarTranning
            // 
            // 
            // 
            // 
            this.proBarTranning.BackgroundStyle.Class = "";
            this.proBarTranning.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.proBarTranning.Location = new System.Drawing.Point(74, 3);
            this.proBarTranning.Name = "proBarTranning";
            this.proBarTranning.Size = new System.Drawing.Size(151, 23);
            this.proBarTranning.TabIndex = 0;
            this.proBarTranning.Text = "0%";
            this.proBarTranning.TextVisible = true;
            this.proBarTranning.Value = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "练习时间：";
            // 
            // UcTraningProgresser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proBarTranning);
            this.Name = "UcTraningProgresser";
            this.Size = new System.Drawing.Size(228, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ProgressBarX proBarTranning;
        private System.Windows.Forms.Label label1;
    }
}
