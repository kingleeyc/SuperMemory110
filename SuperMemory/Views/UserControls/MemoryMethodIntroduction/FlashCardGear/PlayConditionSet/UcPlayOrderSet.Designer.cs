namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    partial class UcPlayOrderSet
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
            this.rbForward = new System.Windows.Forms.RadioButton();
            this.rbReverse = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbForward
            // 
            this.rbForward.AutoSize = true;
            this.rbForward.Checked = true;
            this.rbForward.Location = new System.Drawing.Point(3, 3);
            this.rbForward.Name = "rbForward";
            this.rbForward.Size = new System.Drawing.Size(47, 16);
            this.rbForward.TabIndex = 0;
            this.rbForward.TabStop = true;
            this.rbForward.Text = "顺序";
            this.rbForward.UseVisualStyleBackColor = true;
            this.rbForward.CheckedChanged += new System.EventHandler(this.rbForward_CheckedChanged);
            // 
            // rbReverse
            // 
            this.rbReverse.AutoSize = true;
            this.rbReverse.Location = new System.Drawing.Point(59, 3);
            this.rbReverse.Name = "rbReverse";
            this.rbReverse.Size = new System.Drawing.Size(47, 16);
            this.rbReverse.TabIndex = 1;
            this.rbReverse.Text = "倒序";
            this.rbReverse.UseVisualStyleBackColor = true;
            this.rbReverse.CheckedChanged += new System.EventHandler(this.rbReverse_CheckedChanged);
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(111, 3);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(47, 16);
            this.rbRandom.TabIndex = 2;
            this.rbRandom.Text = "随机";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.CheckedChanged += new System.EventHandler(this.rbRandom_CheckedChanged);
            // 
            // UcPlayOrderSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbRandom);
            this.Controls.Add(this.rbReverse);
            this.Controls.Add(this.rbForward);
            this.Name = "UcPlayOrderSet";
            this.Size = new System.Drawing.Size(163, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbForward;
        private System.Windows.Forms.RadioButton rbReverse;
        private System.Windows.Forms.RadioButton rbRandom;
    }
}
