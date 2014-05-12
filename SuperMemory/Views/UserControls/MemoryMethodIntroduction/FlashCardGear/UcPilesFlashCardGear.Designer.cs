using SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet;
using SuperMemory.Views.UserControls.Common;
namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear
{
    partial class UcPilesFlashCardGear
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
            this.ucLeafPileTypesSelector = new SuperMemory.Views.UserControls.Common.UcLeafPileTypesSelector();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucTraningProgresser = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayProgress.UcTraningProgresser();
            this.ucPileGroupThree = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.UcPileGroupThree();
            this.ucPileGroupTwo = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.UcPileGroupTwo();
            this.ucPileGroupOne = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.UcPileGroupOne();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucPlayController = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayControl.UcPlayController();
            this.ucPlayIntervalSet = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet.UcPlayIntervalSet();
            this.ucTrainPeriodSet = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet.UcTrainPeriodSet();
            this.ucPlayerGroupAmountSet = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet.UcPlayGroupAmountSet();
            this.ucPlayerPrioritySet = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet.UcPlayPrioritySet();
            this.ucPlayerOrderSet = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet.UcPlayOrderSet();
            this.ucPileOrderAreaSet = new SuperMemory.Views.UserControls.Common.UcPileOrderAreaSet();
            this.ucStepProgresser = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayProgress.UcStepProgresser();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucLeafPileTypesSelector
            // 
            this.ucLeafPileTypesSelector.Location = new System.Drawing.Point(6, 16);
            this.ucLeafPileTypesSelector.Name = "ucLeafPileTypesSelector";
            this.ucLeafPileTypesSelector.Size = new System.Drawing.Size(223, 53);
            this.ucLeafPileTypesSelector.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucStepProgresser);
            this.groupBox1.Controls.Add(this.ucTraningProgresser);
            this.groupBox1.Controls.Add(this.ucPileGroupThree);
            this.groupBox1.Controls.Add(this.ucPileGroupTwo);
            this.groupBox1.Controls.Add(this.ucPileGroupOne);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ucPileOrderAreaSet);
            this.groupBox1.Controls.Add(this.ucLeafPileTypesSelector);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 501);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "闪卡齿轮";
            // 
            // ucTraningProgresser
            // 
            this.ucTraningProgresser.Location = new System.Drawing.Point(441, 30);
            this.ucTraningProgresser.Name = "ucTraningProgresser";
            this.ucTraningProgresser.Size = new System.Drawing.Size(228, 28);
            this.ucTraningProgresser.TabIndex = 6;
            // 
            // ucPileGroupThree
            // 
            this.ucPileGroupThree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPileGroupThree.Location = new System.Drawing.Point(87, 146);
            this.ucPileGroupThree.Name = "ucPileGroupThree";
            this.ucPileGroupThree.Size = new System.Drawing.Size(829, 325);
            this.ucPileGroupThree.TabIndex = 5;
            this.ucPileGroupThree.Visible = false;
            // 
            // ucPileGroupTwo
            // 
            this.ucPileGroupTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPileGroupTwo.Location = new System.Drawing.Point(220, 146);
            this.ucPileGroupTwo.Name = "ucPileGroupTwo";
            this.ucPileGroupTwo.Size = new System.Drawing.Size(555, 325);
            this.ucPileGroupTwo.TabIndex = 4;
            this.ucPileGroupTwo.Visible = false;
            // 
            // ucPileGroupOne
            // 
            this.ucPileGroupOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPileGroupOne.Location = new System.Drawing.Point(360, 146);
            this.ucPileGroupOne.Name = "ucPileGroupOne";
            this.ucPileGroupOne.Size = new System.Drawing.Size(279, 325);
            this.ucPileGroupOne.TabIndex = 3;
            this.ucPileGroupOne.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucPlayController);
            this.groupBox2.Controls.Add(this.ucPlayIntervalSet);
            this.groupBox2.Controls.Add(this.ucTrainPeriodSet);
            this.groupBox2.Controls.Add(this.ucPlayerGroupAmountSet);
            this.groupBox2.Controls.Add(this.ucPlayerPrioritySet);
            this.groupBox2.Controls.Add(this.ucPlayerOrderSet);
            this.groupBox2.Location = new System.Drawing.Point(6, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(962, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // ucPlayController
            // 
            this.ucPlayController.Location = new System.Drawing.Point(742, 17);
            this.ucPlayController.Name = "ucPlayController";
            this.ucPlayController.Size = new System.Drawing.Size(187, 30);
            this.ucPlayController.TabIndex = 5;
            // 
            // ucPlayIntervalSet
            // 
            this.ucPlayIntervalSet.Location = new System.Drawing.Point(585, 19);
            this.ucPlayIntervalSet.Name = "ucPlayIntervalSet";
            this.ucPlayIntervalSet.Size = new System.Drawing.Size(128, 26);
            this.ucPlayIntervalSet.TabIndex = 4;
            // 
            // ucTrainPeriodSet
            // 
            this.ucTrainPeriodSet.Location = new System.Drawing.Point(450, 19);
            this.ucTrainPeriodSet.Name = "ucTrainPeriodSet";
            this.ucTrainPeriodSet.Size = new System.Drawing.Size(128, 26);
            this.ucTrainPeriodSet.TabIndex = 3;
            // 
            // ucPlayerGroupAmountSet
            // 
            this.ucPlayerGroupAmountSet.Location = new System.Drawing.Point(312, 19);
            this.ucPlayerGroupAmountSet.Name = "ucPlayerGroupAmountSet";
            this.ucPlayerGroupAmountSet.Size = new System.Drawing.Size(124, 26);
            this.ucPlayerGroupAmountSet.TabIndex = 2;
            // 
            // ucPlayerPrioritySet
            // 
            this.ucPlayerPrioritySet.Enabled = false;
            this.ucPlayerPrioritySet.Location = new System.Drawing.Point(176, 19);
            this.ucPlayerPrioritySet.Name = "ucPlayerPrioritySet";
            this.ucPlayerPrioritySet.Size = new System.Drawing.Size(130, 28);
            this.ucPlayerPrioritySet.TabIndex = 1;
            this.ucPlayerPrioritySet.Visible = false;
            // 
            // ucPlayerOrderSet
            // 
            this.ucPlayerOrderSet.Location = new System.Drawing.Point(7, 21);
            this.ucPlayerOrderSet.Name = "ucPlayerOrderSet";
            this.ucPlayerOrderSet.Size = new System.Drawing.Size(163, 23);
            this.ucPlayerOrderSet.TabIndex = 0;
            // 
            // ucPileOrderAreaSet
            // 
            this.ucPileOrderAreaSet.Location = new System.Drawing.Point(235, 12);
            this.ucPileOrderAreaSet.Name = "ucPileOrderAreaSet";
            this.ucPileOrderAreaSet.Size = new System.Drawing.Size(191, 57);
            this.ucPileOrderAreaSet.TabIndex = 1;
            // 
            // ucStepProgresser
            // 
            this.ucStepProgresser.Location = new System.Drawing.Point(685, 29);
            this.ucStepProgresser.Name = "ucStepProgresser";
            this.ucStepProgresser.Size = new System.Drawing.Size(228, 28);
            this.ucStepProgresser.TabIndex = 7;
            // 
            // UcPilesFlashCardGear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcPilesFlashCardGear";
            this.Size = new System.Drawing.Size(981, 501);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.Common.UcLeafPileTypesSelector ucLeafPileTypesSelector;
        private System.Windows.Forms.GroupBox groupBox1;
        private UcPileOrderAreaSet ucPileOrderAreaSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private UcPlayOrderSet ucPlayerOrderSet;
        private UcPlayPrioritySet ucPlayerPrioritySet;
        private UcPlayGroupAmountSet ucPlayerGroupAmountSet;
        private UcTrainPeriodSet ucTrainPeriodSet;
        private UcPlayIntervalSet ucPlayIntervalSet;
        private SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayControl.UcPlayController ucPlayController;
        private UcPileGroupOne ucPileGroupOne;
        private UcPileGroupTwo ucPileGroupTwo;
        private UcPileGroupThree ucPileGroupThree;
        private SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayProgress.UcTraningProgresser ucTraningProgresser;
        private SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayProgress.UcStepProgresser ucStepProgresser;
    }
}
