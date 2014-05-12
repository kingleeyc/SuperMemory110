namespace SuperMemory.Views.UserControls.DataMgr
{
    partial class UcPilesDataMgr
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvPileTypes = new System.Windows.Forms.TreeView();
            this.cmsPileTypesOper = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNewPileType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditPileType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeletePileType = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPilesOper = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNewPile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditPile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeletePile = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPilesGrid = new System.Windows.Forms.GroupBox();
            this.dgvPiles = new System.Windows.Forms.DataGridView();
            this.colPilePic = new System.Windows.Forms.DataGridViewImageColumn();
            this.colPileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPileWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPileRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPileAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPileTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPileOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPilePicSrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelPile = new System.Windows.Forms.Button();
            this.btnEditPile = new System.Windows.Forms.Button();
            this.btnNewPile = new System.Windows.Forms.Button();
            this.gbPileDetail = new System.Windows.Forms.GroupBox();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSavePile = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picbPile = new System.Windows.Forms.PictureBox();
            this.rtbPileAction = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPileWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPileNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogPilePic = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.cmsPileTypesOper.SuspendLayout();
            this.cmsPilesOper.SuspendLayout();
            this.gbPilesGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiles)).BeginInit();
            this.gbPileDetail.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbPile)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tvPileTypes);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 643);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "桩类别树";
            // 
            // tvPileTypes
            // 
            this.tvPileTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvPileTypes.Location = new System.Drawing.Point(3, 17);
            this.tvPileTypes.Name = "tvPileTypes";
            this.tvPileTypes.Size = new System.Drawing.Size(253, 623);
            this.tvPileTypes.TabIndex = 0;
            this.tvPileTypes.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvPileTypes_NodeMouseClick);
            // 
            // cmsPileTypesOper
            // 
            this.cmsPileTypesOper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewPileType,
            this.tsmiEditPileType,
            this.tsmiDeletePileType});
            this.cmsPileTypesOper.Name = "cmsPileTypesOper";
            this.cmsPileTypesOper.Size = new System.Drawing.Size(119, 70);
            // 
            // tsmiNewPileType
            // 
            this.tsmiNewPileType.Name = "tsmiNewPileType";
            this.tsmiNewPileType.Size = new System.Drawing.Size(118, 22);
            this.tsmiNewPileType.Text = "新建类别";
            this.tsmiNewPileType.Click += new System.EventHandler(this.tsmiNewPileType_Click);
            // 
            // tsmiEditPileType
            // 
            this.tsmiEditPileType.Name = "tsmiEditPileType";
            this.tsmiEditPileType.Size = new System.Drawing.Size(118, 22);
            this.tsmiEditPileType.Text = "编辑类别";
            this.tsmiEditPileType.Click += new System.EventHandler(this.tsmiEditPileType_Click);
            // 
            // tsmiDeletePileType
            // 
            this.tsmiDeletePileType.Name = "tsmiDeletePileType";
            this.tsmiDeletePileType.Size = new System.Drawing.Size(118, 22);
            this.tsmiDeletePileType.Text = "删除类别";
            this.tsmiDeletePileType.Click += new System.EventHandler(this.tsmiDeletePileType_Click);
            // 
            // cmsPilesOper
            // 
            this.cmsPilesOper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewPile,
            this.tsmiEditPile,
            this.tsmiDeletePile});
            this.cmsPilesOper.Name = "cmsPilesOper";
            this.cmsPilesOper.Size = new System.Drawing.Size(107, 70);
            // 
            // tsmiNewPile
            // 
            this.tsmiNewPile.Name = "tsmiNewPile";
            this.tsmiNewPile.Size = new System.Drawing.Size(106, 22);
            this.tsmiNewPile.Text = "新建桩";
            // 
            // tsmiEditPile
            // 
            this.tsmiEditPile.Name = "tsmiEditPile";
            this.tsmiEditPile.Size = new System.Drawing.Size(106, 22);
            this.tsmiEditPile.Text = "编辑桩";
            // 
            // tsmiDeletePile
            // 
            this.tsmiDeletePile.Name = "tsmiDeletePile";
            this.tsmiDeletePile.Size = new System.Drawing.Size(106, 22);
            this.tsmiDeletePile.Text = "删除桩";
            // 
            // gbPilesGrid
            // 
            this.gbPilesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPilesGrid.Controls.Add(this.dgvPiles);
            this.gbPilesGrid.Controls.Add(this.btnDelPile);
            this.gbPilesGrid.Controls.Add(this.btnSavePile);
            this.gbPilesGrid.Controls.Add(this.btnEditPile);
            this.gbPilesGrid.Controls.Add(this.btnNewPile);
            this.gbPilesGrid.Location = new System.Drawing.Point(269, 4);
            this.gbPilesGrid.Name = "gbPilesGrid";
            this.gbPilesGrid.Size = new System.Drawing.Size(404, 643);
            this.gbPilesGrid.TabIndex = 2;
            this.gbPilesGrid.TabStop = false;
            this.gbPilesGrid.Text = "桩库";
            // 
            // dgvPiles
            // 
            this.dgvPiles.AllowUserToAddRows = false;
            this.dgvPiles.AllowUserToDeleteRows = false;
            this.dgvPiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPilePic,
            this.colPileNumber,
            this.colPileWord,
            this.colPileRole,
            this.colPileAction,
            this.colPileTypeId,
            this.colPileOrder,
            this.colPilePicSrc});
            this.dgvPiles.Location = new System.Drawing.Point(7, 51);
            this.dgvPiles.MultiSelect = false;
            this.dgvPiles.Name = "dgvPiles";
            this.dgvPiles.ReadOnly = true;
            this.dgvPiles.RowTemplate.Height = 64;
            this.dgvPiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPiles.Size = new System.Drawing.Size(391, 586);
            this.dgvPiles.TabIndex = 3;
            this.dgvPiles.SelectionChanged += new System.EventHandler(this.dgvPiles_SelectionChanged);
            // 
            // colPilePic
            // 
            this.colPilePic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPilePic.HeaderText = "图像";
            this.colPilePic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colPilePic.Name = "colPilePic";
            this.colPilePic.ReadOnly = true;
            this.colPilePic.Width = 64;
            // 
            // colPileNumber
            // 
            this.colPileNumber.DataPropertyName = "pilenumber";
            this.colPileNumber.HeaderText = "桩号";
            this.colPileNumber.Name = "colPileNumber";
            this.colPileNumber.ReadOnly = true;
            this.colPileNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPileWord
            // 
            this.colPileWord.DataPropertyName = "pileword";
            this.colPileWord.HeaderText = "谐音词";
            this.colPileWord.Name = "colPileWord";
            this.colPileWord.ReadOnly = true;
            this.colPileWord.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPileRole
            // 
            this.colPileRole.DataPropertyName = "pilerole";
            this.colPileRole.HeaderText = "角色";
            this.colPileRole.Name = "colPileRole";
            this.colPileRole.ReadOnly = true;
            // 
            // colPileAction
            // 
            this.colPileAction.DataPropertyName = "pileaction";
            this.colPileAction.HeaderText = "动作";
            this.colPileAction.Name = "colPileAction";
            this.colPileAction.ReadOnly = true;
            this.colPileAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPileAction.Width = 200;
            // 
            // colPileTypeId
            // 
            this.colPileTypeId.DataPropertyName = "piletypeid";
            this.colPileTypeId.HeaderText = "PileTypeId";
            this.colPileTypeId.Name = "colPileTypeId";
            this.colPileTypeId.ReadOnly = true;
            this.colPileTypeId.Visible = false;
            // 
            // colPileOrder
            // 
            this.colPileOrder.DataPropertyName = "primorder";
            this.colPileOrder.HeaderText = "PileOrder";
            this.colPileOrder.Name = "colPileOrder";
            this.colPileOrder.ReadOnly = true;
            this.colPileOrder.Visible = false;
            // 
            // colPilePicSrc
            // 
            this.colPilePicSrc.DataPropertyName = "pilepic";
            this.colPilePicSrc.HeaderText = "PilePicSrc";
            this.colPilePicSrc.Name = "colPilePicSrc";
            this.colPilePicSrc.ReadOnly = true;
            this.colPilePicSrc.Visible = false;
            // 
            // btnDelPile
            // 
            this.btnDelPile.Location = new System.Drawing.Point(169, 22);
            this.btnDelPile.Name = "btnDelPile";
            this.btnDelPile.Size = new System.Drawing.Size(75, 23);
            this.btnDelPile.TabIndex = 2;
            this.btnDelPile.Text = "删除";
            this.btnDelPile.UseVisualStyleBackColor = true;
            this.btnDelPile.Click += new System.EventHandler(this.btnDelPile_Click);
            // 
            // btnEditPile
            // 
            this.btnEditPile.Location = new System.Drawing.Point(88, 20);
            this.btnEditPile.Name = "btnEditPile";
            this.btnEditPile.Size = new System.Drawing.Size(75, 23);
            this.btnEditPile.TabIndex = 1;
            this.btnEditPile.Text = "编辑";
            this.btnEditPile.UseVisualStyleBackColor = true;
            this.btnEditPile.Click += new System.EventHandler(this.btnEditPile_Click);
            // 
            // btnNewPile
            // 
            this.btnNewPile.Location = new System.Drawing.Point(7, 20);
            this.btnNewPile.Name = "btnNewPile";
            this.btnNewPile.Size = new System.Drawing.Size(75, 23);
            this.btnNewPile.TabIndex = 0;
            this.btnNewPile.Text = "新建";
            this.btnNewPile.UseVisualStyleBackColor = true;
            this.btnNewPile.Click += new System.EventHandler(this.btnNewPile_Click);
            // 
            // gbPileDetail
            // 
            this.gbPileDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPileDetail.Controls.Add(this.tbRole);
            this.gbPileDetail.Controls.Add(this.label4);
            this.gbPileDetail.Controls.Add(this.groupBox4);
            this.gbPileDetail.Controls.Add(this.rtbPileAction);
            this.gbPileDetail.Controls.Add(this.label3);
            this.gbPileDetail.Controls.Add(this.tbPileWord);
            this.gbPileDetail.Controls.Add(this.label2);
            this.gbPileDetail.Controls.Add(this.tbPileNumber);
            this.gbPileDetail.Controls.Add(this.label1);
            this.gbPileDetail.Location = new System.Drawing.Point(680, 4);
            this.gbPileDetail.Name = "gbPileDetail";
            this.gbPileDetail.Size = new System.Drawing.Size(329, 643);
            this.gbPileDetail.TabIndex = 3;
            this.gbPileDetail.TabStop = false;
            this.gbPileDetail.Text = "桩明细,当前操作：";
            // 
            // tbRole
            // 
            this.tbRole.Location = new System.Drawing.Point(80, 97);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(231, 21);
            this.tbRole.TabIndex = 9;
            this.tbRole.TextChanged += new System.EventHandler(this.tbRole_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "角色：";
            // 
            // btnSavePile
            // 
            this.btnSavePile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePile.Location = new System.Drawing.Point(323, 20);
            this.btnSavePile.Name = "btnSavePile";
            this.btnSavePile.Size = new System.Drawing.Size(75, 23);
            this.btnSavePile.TabIndex = 7;
            this.btnSavePile.Text = "保存";
            this.btnSavePile.UseVisualStyleBackColor = true;
            this.btnSavePile.Click += new System.EventHandler(this.btnSavePile_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picbPile);
            this.groupBox4.Location = new System.Drawing.Point(18, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 328);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "图像：";
            // 
            // picbPile
            // 
            this.picbPile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbPile.Location = new System.Drawing.Point(3, 17);
            this.picbPile.Name = "picbPile";
            this.picbPile.Size = new System.Drawing.Size(287, 308);
            this.picbPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbPile.TabIndex = 1;
            this.picbPile.TabStop = false;
            this.picbPile.Click += new System.EventHandler(this.picbPile_Click);
            // 
            // rtbPileAction
            // 
            this.rtbPileAction.Location = new System.Drawing.Point(80, 147);
            this.rtbPileAction.Name = "rtbPileAction";
            this.rtbPileAction.Size = new System.Drawing.Size(231, 74);
            this.rtbPileAction.TabIndex = 5;
            this.rtbPileAction.Text = "";
            this.rtbPileAction.TextChanged += new System.EventHandler(this.rtbPileAction_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "动作：";
            // 
            // tbPileWord
            // 
            this.tbPileWord.Location = new System.Drawing.Point(80, 62);
            this.tbPileWord.Name = "tbPileWord";
            this.tbPileWord.Size = new System.Drawing.Size(231, 21);
            this.tbPileWord.TabIndex = 3;
            this.tbPileWord.TextChanged += new System.EventHandler(this.tbPileWord_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "谐音词：";
            // 
            // tbPileNumber
            // 
            this.tbPileNumber.Location = new System.Drawing.Point(80, 29);
            this.tbPileNumber.Name = "tbPileNumber";
            this.tbPileNumber.Size = new System.Drawing.Size(231, 21);
            this.tbPileNumber.TabIndex = 1;
            this.tbPileNumber.TextChanged += new System.EventHandler(this.tbPileNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "桩号：";
            // 
            // UcPilesDataMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.gbPileDetail);
            this.Controls.Add(this.gbPilesGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcPilesDataMgr";
            this.Size = new System.Drawing.Size(1009, 650);
            this.groupBox1.ResumeLayout(false);
            this.cmsPileTypesOper.ResumeLayout(false);
            this.cmsPilesOper.ResumeLayout(false);
            this.gbPilesGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiles)).EndInit();
            this.gbPileDetail.ResumeLayout(false);
            this.gbPileDetail.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbPile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvPileTypes;
        private System.Windows.Forms.ContextMenuStrip cmsPileTypesOper;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewPileType;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPileType;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeletePileType;
        private System.Windows.Forms.ContextMenuStrip cmsPilesOper;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewPile;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPile;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeletePile;
        private System.Windows.Forms.GroupBox gbPilesGrid;
        private System.Windows.Forms.Button btnDelPile;
        private System.Windows.Forms.Button btnEditPile;
        private System.Windows.Forms.Button btnNewPile;
        private System.Windows.Forms.DataGridView dgvPiles;
        private System.Windows.Forms.GroupBox gbPileDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPileNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPileWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbPileAction;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picbPile;
        private System.Windows.Forms.Button btnSavePile;
        private System.Windows.Forms.OpenFileDialog openFileDialogPilePic;
        private System.Windows.Forms.TextBox tbRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn colPilePic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPileWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPileRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPileAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPileTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPileOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPilePicSrc;
    }
}
