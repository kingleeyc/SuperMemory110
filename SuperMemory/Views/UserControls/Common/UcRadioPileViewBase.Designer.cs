namespace SuperMemory.Views.UserControls.Common
{
    partial class UcRadioPileViewBase
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
            this.ucPileViewBase = new SuperMemory.Views.UserControls.Common.UcPileViewBase();
            this.SuspendLayout();
            // 
            // ucPileViewBase
            // 
            this.ucPileViewBase.BackColor = System.Drawing.Color.LightGray;
            this.ucPileViewBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPileViewBase.Location = new System.Drawing.Point(0, 0);
            this.ucPileViewBase.Name = "ucPileViewBase";
            this.ucPileViewBase.Size = new System.Drawing.Size(150, 150);
            this.ucPileViewBase.TabIndex = 0;
            this.ucPileViewBase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ucPileViewBase_MouseClick);
            // 
            // UcRadioPileViewBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ucPileViewBase);
            this.Name = "UcRadioPileViewBase";
            this.ResumeLayout(false);

        }

        #endregion

        private UcPileViewBase ucPileViewBase;

    }
}
