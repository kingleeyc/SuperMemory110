namespace SuperMemory.Views.UserControls.Common
{
    partial class UcLeafPileTypesSelector
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
            this.cbbPileTypes = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbPileTypes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "桩类别";
            // 
            // cbbPileTypes
            // 
            this.cbbPileTypes.DisplayMember = "piletypename";
            this.cbbPileTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPileTypes.FormattingEnabled = true;
            this.cbbPileTypes.Location = new System.Drawing.Point(6, 20);
            this.cbbPileTypes.Name = "cbbPileTypes";
            this.cbbPileTypes.Size = new System.Drawing.Size(207, 20);
            this.cbbPileTypes.TabIndex = 0;
            this.cbbPileTypes.ValueMember = "piletypeid";
            this.cbbPileTypes.SelectedIndexChanged += new System.EventHandler(this.cbbPileTypes_SelectedIndexChanged);
            // 
            // UcLeafPileTypesSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcLeafPileTypesSelector";
            this.Size = new System.Drawing.Size(219, 53);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbPileTypes;
    }
}
