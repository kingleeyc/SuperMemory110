namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding
{
    partial class UcTranscodingSetting
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPileWord2PileAction = new System.Windows.Forms.Button();
            this.btnPileWord2PileRole = new System.Windows.Forms.Button();
            this.btnPileNum2PileAction = new System.Windows.Forms.Button();
            this.btnPileNum2PileRole = new System.Windows.Forms.Button();
            this.btnPileNum2PileWord = new System.Windows.Forms.Button();
            this.btnPilePic2PileAction = new System.Windows.Forms.Button();
            this.btnPilePic2PileRole = new System.Windows.Forms.Button();
            this.btnPilePic2PileWord = new System.Windows.Forms.Button();
            this.btPilePic2PileNum = new System.Windows.Forms.Button();
            this.ucLeafPileTypesSelector = new SuperMemory.Views.UserControls.Common.UcLeafPileTypesSelector();
            this.ucPileOrderAreaSet = new SuperMemory.Views.UserControls.Common.UcPileOrderAreaSet();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ucLeafPileTypesSelector);
            this.groupBox1.Controls.Add(this.ucPileOrderAreaSet);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 446);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编码转换";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPileWord2PileAction);
            this.groupBox2.Controls.Add(this.btnPileWord2PileRole);
            this.groupBox2.Controls.Add(this.btnPileNum2PileAction);
            this.groupBox2.Controls.Add(this.btnPileNum2PileRole);
            this.groupBox2.Controls.Add(this.btnPileNum2PileWord);
            this.groupBox2.Controls.Add(this.btnPilePic2PileAction);
            this.groupBox2.Controls.Add(this.btnPilePic2PileRole);
            this.groupBox2.Controls.Add(this.btnPilePic2PileWord);
            this.groupBox2.Controls.Add(this.btPilePic2PileNum);
            this.groupBox2.Location = new System.Drawing.Point(23, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 326);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "进入编码转换";
            // 
            // btnPileWord2PileAction
            // 
            this.btnPileWord2PileAction.Enabled = false;
            this.btnPileWord2PileAction.Location = new System.Drawing.Point(189, 262);
            this.btnPileWord2PileAction.Name = "btnPileWord2PileAction";
            this.btnPileWord2PileAction.Size = new System.Drawing.Size(134, 23);
            this.btnPileWord2PileAction.TabIndex = 8;
            this.btnPileWord2PileAction.Text = "词译动作";
            this.btnPileWord2PileAction.UseVisualStyleBackColor = true;
            this.btnPileWord2PileAction.Click += new System.EventHandler(this.btnPileWord2PileAction_Click);
            // 
            // btnPileWord2PileRole
            // 
            this.btnPileWord2PileRole.Enabled = false;
            this.btnPileWord2PileRole.Location = new System.Drawing.Point(189, 233);
            this.btnPileWord2PileRole.Name = "btnPileWord2PileRole";
            this.btnPileWord2PileRole.Size = new System.Drawing.Size(134, 23);
            this.btnPileWord2PileRole.TabIndex = 7;
            this.btnPileWord2PileRole.Text = "词译角色";
            this.btnPileWord2PileRole.UseVisualStyleBackColor = true;
            this.btnPileWord2PileRole.Click += new System.EventHandler(this.btnPileWord2PileRole_Click);
            // 
            // btnPileNum2PileAction
            // 
            this.btnPileNum2PileAction.Enabled = false;
            this.btnPileNum2PileAction.Location = new System.Drawing.Point(189, 204);
            this.btnPileNum2PileAction.Name = "btnPileNum2PileAction";
            this.btnPileNum2PileAction.Size = new System.Drawing.Size(134, 23);
            this.btnPileNum2PileAction.TabIndex = 6;
            this.btnPileNum2PileAction.Text = "桩号译动作";
            this.btnPileNum2PileAction.UseVisualStyleBackColor = true;
            this.btnPileNum2PileAction.Click += new System.EventHandler(this.btnPileNum2PileAction_Click);
            // 
            // btnPileNum2PileRole
            // 
            this.btnPileNum2PileRole.Enabled = false;
            this.btnPileNum2PileRole.Location = new System.Drawing.Point(189, 175);
            this.btnPileNum2PileRole.Name = "btnPileNum2PileRole";
            this.btnPileNum2PileRole.Size = new System.Drawing.Size(134, 23);
            this.btnPileNum2PileRole.TabIndex = 5;
            this.btnPileNum2PileRole.Text = "桩号译角色";
            this.btnPileNum2PileRole.UseVisualStyleBackColor = true;
            this.btnPileNum2PileRole.Click += new System.EventHandler(this.btnPileNum2PileRole_Click);
            // 
            // btnPileNum2PileWord
            // 
            this.btnPileNum2PileWord.Enabled = false;
            this.btnPileNum2PileWord.Location = new System.Drawing.Point(189, 146);
            this.btnPileNum2PileWord.Name = "btnPileNum2PileWord";
            this.btnPileNum2PileWord.Size = new System.Drawing.Size(134, 23);
            this.btnPileNum2PileWord.TabIndex = 4;
            this.btnPileNum2PileWord.Text = "桩号译词";
            this.btnPileNum2PileWord.UseVisualStyleBackColor = true;
            this.btnPileNum2PileWord.Click += new System.EventHandler(this.btnPileNum2PileWord_Click);
            // 
            // btnPilePic2PileAction
            // 
            this.btnPilePic2PileAction.Enabled = false;
            this.btnPilePic2PileAction.Location = new System.Drawing.Point(189, 117);
            this.btnPilePic2PileAction.Name = "btnPilePic2PileAction";
            this.btnPilePic2PileAction.Size = new System.Drawing.Size(134, 23);
            this.btnPilePic2PileAction.TabIndex = 3;
            this.btnPilePic2PileAction.Text = "图译动作";
            this.btnPilePic2PileAction.UseVisualStyleBackColor = true;
            this.btnPilePic2PileAction.Click += new System.EventHandler(this.btnPilePic2PileAction_Click);
            // 
            // btnPilePic2PileRole
            // 
            this.btnPilePic2PileRole.Enabled = false;
            this.btnPilePic2PileRole.Location = new System.Drawing.Point(189, 88);
            this.btnPilePic2PileRole.Name = "btnPilePic2PileRole";
            this.btnPilePic2PileRole.Size = new System.Drawing.Size(134, 23);
            this.btnPilePic2PileRole.TabIndex = 2;
            this.btnPilePic2PileRole.Text = "图译角色";
            this.btnPilePic2PileRole.UseVisualStyleBackColor = true;
            this.btnPilePic2PileRole.Click += new System.EventHandler(this.btnPilePic2PileRole_Click);
            // 
            // btnPilePic2PileWord
            // 
            this.btnPilePic2PileWord.Enabled = false;
            this.btnPilePic2PileWord.Location = new System.Drawing.Point(189, 59);
            this.btnPilePic2PileWord.Name = "btnPilePic2PileWord";
            this.btnPilePic2PileWord.Size = new System.Drawing.Size(134, 23);
            this.btnPilePic2PileWord.TabIndex = 1;
            this.btnPilePic2PileWord.Text = "图译词";
            this.btnPilePic2PileWord.UseVisualStyleBackColor = true;
            this.btnPilePic2PileWord.Click += new System.EventHandler(this.btnPilePic2PileWord_Click);
            // 
            // btPilePic2PileNum
            // 
            this.btPilePic2PileNum.Enabled = false;
            this.btPilePic2PileNum.Location = new System.Drawing.Point(189, 30);
            this.btPilePic2PileNum.Name = "btPilePic2PileNum";
            this.btPilePic2PileNum.Size = new System.Drawing.Size(134, 23);
            this.btPilePic2PileNum.TabIndex = 0;
            this.btPilePic2PileNum.Text = "图译桩号";
            this.btPilePic2PileNum.UseVisualStyleBackColor = true;
            this.btPilePic2PileNum.Click += new System.EventHandler(this.btPilePic2PileNum_Click);
            // 
            // ucLeafPileTypesSelector
            // 
            this.ucLeafPileTypesSelector.Location = new System.Drawing.Point(23, 29);
            this.ucLeafPileTypesSelector.Name = "ucLeafPileTypesSelector";
            this.ucLeafPileTypesSelector.Size = new System.Drawing.Size(219, 53);
            this.ucLeafPileTypesSelector.TabIndex = 1;
            // 
            // ucPileOrderAreaSet
            // 
            this.ucPileOrderAreaSet.Location = new System.Drawing.Point(339, 29);
            this.ucPileOrderAreaSet.Name = "ucPileOrderAreaSet";
            this.ucPileOrderAreaSet.Size = new System.Drawing.Size(198, 53);
            this.ucPileOrderAreaSet.TabIndex = 0;
            // 
            // UcTranscodingSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcTranscodingSetting";
            this.Size = new System.Drawing.Size(559, 446);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPilePic2PileAction;
        private System.Windows.Forms.Button btnPilePic2PileRole;
        private System.Windows.Forms.Button btnPilePic2PileWord;
        private System.Windows.Forms.Button btPilePic2PileNum;
        private SuperMemory.Views.UserControls.Common.UcLeafPileTypesSelector ucLeafPileTypesSelector;
        private SuperMemory.Views.UserControls.Common.UcPileOrderAreaSet ucPileOrderAreaSet;
        private System.Windows.Forms.Button btnPileNum2PileWord;
        private System.Windows.Forms.Button btnPileNum2PileRole;
        private System.Windows.Forms.Button btnPileNum2PileAction;
        private System.Windows.Forms.Button btnPileWord2PileAction;
        private System.Windows.Forms.Button btnPileWord2PileRole;
    }
}
