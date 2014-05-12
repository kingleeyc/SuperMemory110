namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning
{
    partial class UcChoiceOne
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
            this.lbChoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbChoice
            // 
            this.lbChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbChoice.ForeColor = System.Drawing.Color.Green;
            this.lbChoice.Location = new System.Drawing.Point(0, 0);
            this.lbChoice.Name = "lbChoice";
            this.lbChoice.Size = new System.Drawing.Size(218, 206);
            this.lbChoice.TabIndex = 1;
            this.lbChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbChoice.MouseLeave += new System.EventHandler(this.lbChoice_MouseLeave);
            this.lbChoice.Click += new System.EventHandler(this.lbChoice_Click);
            this.lbChoice.MouseEnter += new System.EventHandler(this.lbChoice_MouseEnter);
            // 
            // UcChoiceOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbChoice);
            this.Name = "UcChoiceOne";
            this.Size = new System.Drawing.Size(218, 206);
            this.Load += new System.EventHandler(this.UcChoiceOne_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbChoice;
    }
}
