namespace SuperMemory.Views.UserControls.DataMgr.Exam
{
    partial class UcExamLevels
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
            this.dgvLevels = new System.Windows.Forms.DataGridView();
            this.colLevelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupPilesNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPilesType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelPile = new System.Windows.Forms.Button();
            this.btnSavePile = new System.Windows.Forms.Button();
            this.btnEditPile = new System.Windows.Forms.Button();
            this.btnNewPile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelPile);
            this.groupBox1.Controls.Add(this.btnSavePile);
            this.groupBox1.Controls.Add(this.btnEditPile);
            this.groupBox1.Controls.Add(this.btnNewPile);
            this.groupBox1.Controls.Add(this.dgvLevels);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 572);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "关卡列表";
            // 
            // dgvLevels
            // 
            this.dgvLevels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLevels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLevelName,
            this.colOrder,
            this.colGroupPilesNum,
            this.colPilesType});
            this.dgvLevels.Location = new System.Drawing.Point(6, 61);
            this.dgvLevels.Name = "dgvLevels";
            this.dgvLevels.RowTemplate.Height = 23;
            this.dgvLevels.Size = new System.Drawing.Size(640, 505);
            this.dgvLevels.TabIndex = 0;
            // 
            // colLevelName
            // 
            this.colLevelName.HeaderText = "名称";
            this.colLevelName.Name = "colLevelName";
            this.colLevelName.ReadOnly = true;
            this.colLevelName.Width = 200;
            // 
            // colOrder
            // 
            this.colOrder.HeaderText = "顺序";
            this.colOrder.Name = "colOrder";
            this.colOrder.ReadOnly = true;
            // 
            // colGroupPilesNum
            // 
            this.colGroupPilesNum.HeaderText = "每组桩数";
            this.colGroupPilesNum.Name = "colGroupPilesNum";
            this.colGroupPilesNum.ReadOnly = true;
            // 
            // colPilesType
            // 
            this.colPilesType.HeaderText = "桩库";
            this.colPilesType.Name = "colPilesType";
            this.colPilesType.ReadOnly = true;
            this.colPilesType.Width = 200;
            // 
            // btnDelPile
            // 
            this.btnDelPile.Location = new System.Drawing.Point(179, 22);
            this.btnDelPile.Name = "btnDelPile";
            this.btnDelPile.Size = new System.Drawing.Size(75, 23);
            this.btnDelPile.TabIndex = 10;
            this.btnDelPile.Text = "删除";
            this.btnDelPile.UseVisualStyleBackColor = true;
            // 
            // btnSavePile
            // 
            this.btnSavePile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePile.Location = new System.Drawing.Point(562, 20);
            this.btnSavePile.Name = "btnSavePile";
            this.btnSavePile.Size = new System.Drawing.Size(75, 23);
            this.btnSavePile.TabIndex = 11;
            this.btnSavePile.Text = "保存";
            this.btnSavePile.UseVisualStyleBackColor = true;
            // 
            // btnEditPile
            // 
            this.btnEditPile.Location = new System.Drawing.Point(98, 20);
            this.btnEditPile.Name = "btnEditPile";
            this.btnEditPile.Size = new System.Drawing.Size(75, 23);
            this.btnEditPile.TabIndex = 9;
            this.btnEditPile.Text = "编辑";
            this.btnEditPile.UseVisualStyleBackColor = true;
            // 
            // btnNewPile
            // 
            this.btnNewPile.Location = new System.Drawing.Point(17, 20);
            this.btnNewPile.Name = "btnNewPile";
            this.btnNewPile.Size = new System.Drawing.Size(75, 23);
            this.btnNewPile.TabIndex = 8;
            this.btnNewPile.Text = "新建";
            this.btnNewPile.UseVisualStyleBackColor = true;
            // 
            // UcExamLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcExamLevels";
            this.Size = new System.Drawing.Size(652, 572);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLevels;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupPilesNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPilesType;
        private System.Windows.Forms.Button btnDelPile;
        private System.Windows.Forms.Button btnSavePile;
        private System.Windows.Forms.Button btnEditPile;
        private System.Windows.Forms.Button btnNewPile;
    }
}
