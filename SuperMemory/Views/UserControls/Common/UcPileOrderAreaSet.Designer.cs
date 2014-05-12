namespace SuperMemory.Views.UserControls.Common
{
    partial class UcPileOrderAreaSet
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPileOrderEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPileOrderBegin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPileOrderEnd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbPileOrderBegin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "桩范围 1~N";
            // 
            // tbPileOrderEnd
            // 
            this.tbPileOrderEnd.Location = new System.Drawing.Point(146, 20);
            this.tbPileOrderEnd.Name = "tbPileOrderEnd";
            this.tbPileOrderEnd.Size = new System.Drawing.Size(37, 21);
            this.tbPileOrderEnd.TabIndex = 3;
            this.tbPileOrderEnd.TextChanged += new System.EventHandler(this.tbPileOrderEnd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "结束:";
            // 
            // tbPileOrderBegin
            // 
            this.tbPileOrderBegin.Location = new System.Drawing.Point(50, 20);
            this.tbPileOrderBegin.Name = "tbPileOrderBegin";
            this.tbPileOrderBegin.Size = new System.Drawing.Size(37, 21);
            this.tbPileOrderBegin.TabIndex = 1;
            this.tbPileOrderBegin.TextChanged += new System.EventHandler(this.tbPileOrderBegin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始:";
            // 
            // UcPileOrderAreaSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "UcPileOrderAreaSet";
            this.Size = new System.Drawing.Size(198, 53);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPileOrderEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPileOrderBegin;
        private System.Windows.Forms.Label label1;
    }
}
