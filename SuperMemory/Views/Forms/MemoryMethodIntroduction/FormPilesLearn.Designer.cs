namespace SuperMemory.Views.Forms.MemoryMethodIntroduction
{
    partial class FormPilesLearn
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
            this.ucPielsLearn = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.PilesLearn.UcPielsLearn();
            this.SuspendLayout();
            // 
            // ucPielsLearn
            // 
            this.ucPielsLearn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucPielsLearn.Location = new System.Drawing.Point(87, 22);
            this.ucPielsLearn.Name = "ucPielsLearn";
            this.ucPielsLearn.Size = new System.Drawing.Size(849, 581);
            this.ucPielsLearn.TabIndex = 0;
            // 
            // FormPilesLearn
            // 
            this.ClientSize = new System.Drawing.Size(1028, 633);
            this.Controls.Add(this.ucPielsLearn);
            this.Name = "FormPilesLearn";
            this.TabText = "110桩学习";
            this.Text = "110桩学习";
            this.Load += new System.EventHandler(this.FormPilesLearn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.MemoryMethodIntroduction.PilesLearn.UcPielsLearn ucPielsLearn;
    }
}
