namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning
{
    partial class UcPicChoicePileChoicePart
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
            this.ucChoiceGroup = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning.UcChoiceGroup();
            this.ucPilePicView = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning.UcPilePicView();
            this.SuspendLayout();
            // 
            // ucChoiceGroup
            // 
            this.ucChoiceGroup.Location = new System.Drawing.Point(729, 0);
            this.ucChoiceGroup.Name = "ucChoiceGroup";
            this.ucChoiceGroup.Size = new System.Drawing.Size(207, 612);
            this.ucChoiceGroup.TabIndex = 1;
            // 
            // ucPilePicView
            // 
            this.ucPilePicView.Location = new System.Drawing.Point(0, 3);
            this.ucPilePicView.Name = "ucPilePicView";
            this.ucPilePicView.Size = new System.Drawing.Size(701, 609);
            this.ucPilePicView.TabIndex = 0;
            // 
            // UcPicChoicePileNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucChoiceGroup);
            this.Controls.Add(this.ucPilePicView);
            this.Name = "UcPicChoicePileNumber";
            this.Size = new System.Drawing.Size(944, 623);
            this.ResumeLayout(false);

        }

        #endregion

        private UcPilePicView ucPilePicView;
        private UcChoiceGroup ucChoiceGroup;
    }
}
