namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    partial class UcPlayerPrioritySet
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
            this.cbbData = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbbData
            // 
            this.cbbData.DisplayMember = "propName";
            this.cbbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbData.FormattingEnabled = true;
            this.cbbData.Location = new System.Drawing.Point(4, 4);
            this.cbbData.Name = "cbbData";
            this.cbbData.Size = new System.Drawing.Size(121, 20);
            this.cbbData.TabIndex = 0;
            this.cbbData.ValueMember = "propValue";
            this.cbbData.SelectedIndexChanged += new System.EventHandler(this.cbbData_SelectedIndexChanged);
            // 
            // UcPlayerPrioritySet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbData);
            this.Name = "UcPlayerPrioritySet";
            this.Size = new System.Drawing.Size(130, 28);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbData;
    }
}
