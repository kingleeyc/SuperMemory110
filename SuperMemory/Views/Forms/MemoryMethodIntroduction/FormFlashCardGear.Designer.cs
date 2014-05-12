namespace SuperMemory.Views.Forms.MemoryMethodIntroduction
{
    partial class FormFlashCardGear
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
            this.ucPilesFlashCardGear = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.UcPilesFlashCardGear();
            this.SuspendLayout();
            // 
            // ucPilesFlashCardGear
            // 
            this.ucPilesFlashCardGear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucPilesFlashCardGear.Location = new System.Drawing.Point(61, 55);
            this.ucPilesFlashCardGear.Name = "ucPilesFlashCardGear";
            this.ucPilesFlashCardGear.Size = new System.Drawing.Size(975, 485);
            this.ucPilesFlashCardGear.TabIndex = 0;
            // 
            // FormFlashCardGear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 596);
            this.Controls.Add(this.ucPilesFlashCardGear);
            this.Name = "FormFlashCardGear";
            this.TabText = "闪卡齿轮";
            this.Text = "闪卡齿轮";
            this.Load += new System.EventHandler(this.FormFlashCardGear_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.UcPilesFlashCardGear ucPilesFlashCardGear;
    }
}