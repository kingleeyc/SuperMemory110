namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.PilesLearn
{
    partial class UcPielsLearn
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
            this.picbPile = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.btnGotoNext = new System.Windows.Forms.Button();
            this.btnGotoLast = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbAction = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbPileOrWord = new System.Windows.Forms.Label();
            this.rbWord = new System.Windows.Forms.RadioButton();
            this.rbPileNumber = new System.Windows.Forms.RadioButton();
            this.tbxPileOrWord = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ucLeafPileTypesSelector = new SuperMemory.Views.UserControls.Common.UcLeafPileTypesSelector();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbPile)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picbPile);
            this.groupBox2.Location = new System.Drawing.Point(6, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 467);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图像";
            // 
            // picbPile
            // 
            this.picbPile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbPile.Location = new System.Drawing.Point(3, 17);
            this.picbPile.Name = "picbPile";
            this.picbPile.Size = new System.Drawing.Size(434, 447);
            this.picbPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbPile.TabIndex = 0;
            this.picbPile.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.btnGotoNext);
            this.groupBox3.Controls.Add(this.btnGotoLast);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.rbWord);
            this.groupBox3.Controls.Add(this.rbPileNumber);
            this.groupBox3.Controls.Add(this.tbxPileOrWord);
            this.groupBox3.Location = new System.Drawing.Point(452, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 520);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbRole);
            this.groupBox7.Location = new System.Drawing.Point(8, 267);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(360, 90);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "角色";
            // 
            // lbRole
            // 
            this.lbRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRole.ForeColor = System.Drawing.Color.Red;
            this.lbRole.Location = new System.Drawing.Point(3, 17);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(354, 70);
            this.lbRole.TabIndex = 0;
            this.lbRole.Text = "角色";
            this.lbRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGotoNext
            // 
            this.btnGotoNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGotoNext.FlatAppearance.BorderSize = 0;
            this.btnGotoNext.Image = global::SuperMemory.Properties.Resources.arrow_right_3;
            this.btnGotoNext.Location = new System.Drawing.Point(307, 62);
            this.btnGotoNext.Name = "btnGotoNext";
            this.btnGotoNext.Size = new System.Drawing.Size(35, 51);
            this.btnGotoNext.TabIndex = 7;
            this.btnGotoNext.UseVisualStyleBackColor = true;
            this.btnGotoNext.Click += new System.EventHandler(this.btnGotoNext_Click);
            // 
            // btnGotoLast
            // 
            this.btnGotoLast.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGotoLast.FlatAppearance.BorderSize = 0;
            this.btnGotoLast.Image = global::SuperMemory.Properties.Resources.arrow_left_3;
            this.btnGotoLast.Location = new System.Drawing.Point(266, 62);
            this.btnGotoLast.Name = "btnGotoLast";
            this.btnGotoLast.Size = new System.Drawing.Size(35, 51);
            this.btnGotoLast.TabIndex = 6;
            this.btnGotoLast.UseVisualStyleBackColor = true;
            this.btnGotoLast.Click += new System.EventHandler(this.btnGotoLast_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbAction);
            this.groupBox5.Location = new System.Drawing.Point(10, 363);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(360, 151);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "动作";
            // 
            // lbAction
            // 
            this.lbAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAction.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbAction.Location = new System.Drawing.Point(3, 17);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(354, 131);
            this.lbAction.TabIndex = 0;
            this.lbAction.Text = "动作";
            this.lbAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbPileOrWord);
            this.groupBox4.Location = new System.Drawing.Point(7, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 126);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "谐音词、拼音";
            // 
            // lbPileOrWord
            // 
            this.lbPileOrWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPileOrWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPileOrWord.ForeColor = System.Drawing.Color.Green;
            this.lbPileOrWord.Location = new System.Drawing.Point(3, 17);
            this.lbPileOrWord.Name = "lbPileOrWord";
            this.lbPileOrWord.Size = new System.Drawing.Size(357, 106);
            this.lbPileOrWord.TabIndex = 0;
            this.lbPileOrWord.Text = "label1";
            this.lbPileOrWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbWord
            // 
            this.rbWord.AutoSize = true;
            this.rbWord.Location = new System.Drawing.Point(61, 21);
            this.rbWord.Name = "rbWord";
            this.rbWord.Size = new System.Drawing.Size(59, 16);
            this.rbWord.TabIndex = 3;
            this.rbWord.Text = "谐音词";
            this.rbWord.UseVisualStyleBackColor = true;
            // 
            // rbPileNumber
            // 
            this.rbPileNumber.AutoSize = true;
            this.rbPileNumber.Checked = true;
            this.rbPileNumber.Location = new System.Drawing.Point(7, 21);
            this.rbPileNumber.Name = "rbPileNumber";
            this.rbPileNumber.Size = new System.Drawing.Size(47, 16);
            this.rbPileNumber.TabIndex = 2;
            this.rbPileNumber.TabStop = true;
            this.rbPileNumber.Text = "桩号";
            this.rbPileNumber.UseVisualStyleBackColor = true;
            this.rbPileNumber.CheckedChanged += new System.EventHandler(this.rbPileNumber_CheckedChanged);
            // 
            // tbxPileOrWord
            // 
            // 
            // 
            // 
            this.tbxPileOrWord.Border.Class = "TextBoxBorder";
            this.tbxPileOrWord.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxPileOrWord.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxPileOrWord.Location = new System.Drawing.Point(6, 65);
            this.tbxPileOrWord.Name = "tbxPileOrWord";
            this.tbxPileOrWord.Size = new System.Drawing.Size(254, 44);
            this.tbxPileOrWord.TabIndex = 0;
            this.tbxPileOrWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPileOrWord.TextChanged += new System.EventHandler(this.tbxPileOrWord_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ucLeafPileTypesSelector);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(840, 571);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "记忆桩学习";
            // 
            // ucLeafPileTypesSelector
            // 
            this.ucLeafPileTypesSelector.Location = new System.Drawing.Point(6, 13);
            this.ucLeafPileTypesSelector.Name = "ucLeafPileTypesSelector";
            this.ucLeafPileTypesSelector.Size = new System.Drawing.Size(437, 54);
            this.ucLeafPileTypesSelector.TabIndex = 3;
            // 
            // UcPielsLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Name = "UcPielsLearn";
            this.Size = new System.Drawing.Size(849, 579);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbPile)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxPileOrWord;
        private System.Windows.Forms.RadioButton rbPileNumber;
        private System.Windows.Forms.RadioButton rbWord;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbPileOrWord;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbAction;
        private System.Windows.Forms.Button btnGotoLast;
        private System.Windows.Forms.Button btnGotoNext;
        private System.Windows.Forms.PictureBox picbPile;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbRole;
        private SuperMemory.Views.UserControls.Common.UcLeafPileTypesSelector ucLeafPileTypesSelector;
    }
}
