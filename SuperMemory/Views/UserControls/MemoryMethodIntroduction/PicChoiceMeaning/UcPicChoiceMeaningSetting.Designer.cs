namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning
{
    partial class UcPicChoiceMeaningSetting
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
            this.ucPileOrderAreaSet = new SuperMemory.Views.UserControls.Common.UcPileOrderAreaSet();
            this.ucLeafPileTypesSelector = new SuperMemory.Views.UserControls.Common.UcLeafPileTypesSelector();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPicChoicePileAction = new System.Windows.Forms.Button();
            this.btnPicChoicePileRole = new System.Windows.Forms.Button();
            this.btnPicChoicePileWord = new System.Windows.Forms.Button();
            this.btnPicChoicePileNumber = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPileOrderAreaSet
            // 
            this.ucPileOrderAreaSet.Location = new System.Drawing.Point(339, 29);
            this.ucPileOrderAreaSet.Name = "ucPileOrderAreaSet";
            this.ucPileOrderAreaSet.Size = new System.Drawing.Size(198, 53);
            this.ucPileOrderAreaSet.TabIndex = 0;
            // 
            // ucLeafPileTypesSelector
            // 
            this.ucLeafPileTypesSelector.Location = new System.Drawing.Point(23, 29);
            this.ucLeafPileTypesSelector.Name = "ucLeafPileTypesSelector";
            this.ucLeafPileTypesSelector.Size = new System.Drawing.Size(219, 53);
            this.ucLeafPileTypesSelector.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ucLeafPileTypesSelector);
            this.groupBox1.Controls.Add(this.ucPileOrderAreaSet);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 454);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "看图选义";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPicChoicePileAction);
            this.groupBox2.Controls.Add(this.btnPicChoicePileRole);
            this.groupBox2.Controls.Add(this.btnPicChoicePileWord);
            this.groupBox2.Controls.Add(this.btnPicChoicePileNumber);
            this.groupBox2.Location = new System.Drawing.Point(23, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 326);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "进入看图选义";
            // 
            // btnPicChoicePileAction
            // 
            this.btnPicChoicePileAction.Enabled = false;
            this.btnPicChoicePileAction.Location = new System.Drawing.Point(190, 191);
            this.btnPicChoicePileAction.Name = "btnPicChoicePileAction";
            this.btnPicChoicePileAction.Size = new System.Drawing.Size(134, 23);
            this.btnPicChoicePileAction.TabIndex = 3;
            this.btnPicChoicePileAction.Text = "看图选义（动作）";
            this.btnPicChoicePileAction.UseVisualStyleBackColor = true;
            this.btnPicChoicePileAction.Click += new System.EventHandler(this.btnPicChoicePileAction_Click);
            // 
            // btnPicChoicePileRole
            // 
            this.btnPicChoicePileRole.Enabled = false;
            this.btnPicChoicePileRole.Location = new System.Drawing.Point(190, 152);
            this.btnPicChoicePileRole.Name = "btnPicChoicePileRole";
            this.btnPicChoicePileRole.Size = new System.Drawing.Size(134, 23);
            this.btnPicChoicePileRole.TabIndex = 2;
            this.btnPicChoicePileRole.Text = "看图选义（角色）";
            this.btnPicChoicePileRole.UseVisualStyleBackColor = true;
            this.btnPicChoicePileRole.Click += new System.EventHandler(this.btnPicChoicePileRole_Click);
            // 
            // btnPicChoicePileWord
            // 
            this.btnPicChoicePileWord.Enabled = false;
            this.btnPicChoicePileWord.Location = new System.Drawing.Point(190, 113);
            this.btnPicChoicePileWord.Name = "btnPicChoicePileWord";
            this.btnPicChoicePileWord.Size = new System.Drawing.Size(134, 23);
            this.btnPicChoicePileWord.TabIndex = 1;
            this.btnPicChoicePileWord.Text = "看图选义（谐音）";
            this.btnPicChoicePileWord.UseVisualStyleBackColor = true;
            this.btnPicChoicePileWord.Click += new System.EventHandler(this.btnPicChoicePileWord_Click);
            // 
            // btnPicChoicePileNumber
            // 
            this.btnPicChoicePileNumber.Enabled = false;
            this.btnPicChoicePileNumber.Location = new System.Drawing.Point(190, 72);
            this.btnPicChoicePileNumber.Name = "btnPicChoicePileNumber";
            this.btnPicChoicePileNumber.Size = new System.Drawing.Size(134, 23);
            this.btnPicChoicePileNumber.TabIndex = 0;
            this.btnPicChoicePileNumber.Text = "看图选义（桩号）";
            this.btnPicChoicePileNumber.UseVisualStyleBackColor = true;
            this.btnPicChoicePileNumber.Click += new System.EventHandler(this.btnPicChoicePileNumber_Click);
            // 
            // UcPicChoiceMeaningSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcPicChoiceMeaningSetting";
            this.Size = new System.Drawing.Size(568, 454);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.Common.UcPileOrderAreaSet ucPileOrderAreaSet;
        private SuperMemory.Views.UserControls.Common.UcLeafPileTypesSelector ucLeafPileTypesSelector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPicChoicePileWord;
        private System.Windows.Forms.Button btnPicChoicePileNumber;
        private System.Windows.Forms.Button btnPicChoicePileRole;
        private System.Windows.Forms.Button btnPicChoicePileAction;
    }
}
