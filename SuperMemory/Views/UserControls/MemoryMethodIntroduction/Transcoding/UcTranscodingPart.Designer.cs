namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding
{
    partial class UcTranscodingPart
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucTopPilesGroup = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding.UcTopPilesGroup();
            this.ucBottomPilesGroup = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding.UcBottomPilesGroup();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ucTopPilesGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucBottomPilesGroup, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.62176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.58031F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.53886F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 386);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ucTopPilesGroup
            // 
            this.ucTopPilesGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTopPilesGroup.Location = new System.Drawing.Point(3, 3);
            this.ucTopPilesGroup.Name = "ucTopPilesGroup";
            this.ucTopPilesGroup.Size = new System.Drawing.Size(956, 228);
            this.ucTopPilesGroup.TabIndex = 2;
            // 
            // ucBottomPilesGroup
            // 
            this.ucBottomPilesGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBottomPilesGroup.Location = new System.Drawing.Point(3, 301);
            this.ucBottomPilesGroup.Name = "ucBottomPilesGroup";
            this.ucBottomPilesGroup.Size = new System.Drawing.Size(956, 82);
            this.ucBottomPilesGroup.TabIndex = 3;
            // 
            // UcTranscodingPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcTranscodingPart";
            this.Size = new System.Drawing.Size(962, 386);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UcBottomPilesGroup ucBottomPilesGroup;
        private UcTopPilesGroup ucTopPilesGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
