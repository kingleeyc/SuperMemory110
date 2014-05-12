namespace SuperMemory.Views.Forms.MemoryMethodIntroduction.PicChoiceMeaning
{
    partial class DlgPicChoicePileBase
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
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbRightsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbErrsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbTrainingSecsPass = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateView = new System.Windows.Forms.Timer(this.components);
            this.ucPicChoicePileMain = new SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning.UcPicChoicePileMain();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.AutoSize = false;
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.tsslblUserName,
            this.toolStripStatusLabel1,
            this.tsslbRightsCount,
            this.toolStripStatusLabel3,
            this.tsslbErrsCount,
            this.toolStripStatusLabel4,
            this.tsslbTrainingSecsPass,
            this.tsslblDate});
            this.ssMain.Location = new System.Drawing.Point(0, 720);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1135, 30);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(45, 25);
            this.toolStripStatusLabel2.Text = "用户：";
            // 
            // tsslblUserName
            // 
            this.tsslblUserName.AutoSize = false;
            this.tsslblUserName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslblUserName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslblUserName.IsLink = true;
            this.tsslblUserName.Name = "tsslblUserName";
            this.tsslblUserName.Size = new System.Drawing.Size(100, 25);
            this.tsslblUserName.Text = "张三";
            this.tsslblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 25);
            this.toolStripStatusLabel1.Text = "正确：";
            // 
            // tsslbRightsCount
            // 
            this.tsslbRightsCount.AutoSize = false;
            this.tsslbRightsCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslbRightsCount.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsslbRightsCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.tsslbRightsCount.Name = "tsslbRightsCount";
            this.tsslbRightsCount.Size = new System.Drawing.Size(50, 25);
            this.tsslbRightsCount.Text = "0";
            this.tsslbRightsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(45, 25);
            this.toolStripStatusLabel3.Text = "错误：";
            // 
            // tsslbErrsCount
            // 
            this.tsslbErrsCount.AutoSize = false;
            this.tsslbErrsCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslbErrsCount.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsslbErrsCount.ForeColor = System.Drawing.Color.Red;
            this.tsslbErrsCount.Name = "tsslbErrsCount";
            this.tsslbErrsCount.Size = new System.Drawing.Size(50, 25);
            this.tsslbErrsCount.Text = "0";
            this.tsslbErrsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel4.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(81, 25);
            this.toolStripStatusLabel4.Text = "用时（秒）：";
            // 
            // tsslbTrainingSecsPass
            // 
            this.tsslbTrainingSecsPass.AutoSize = false;
            this.tsslbTrainingSecsPass.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslbTrainingSecsPass.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsslbTrainingSecsPass.ForeColor = System.Drawing.Color.Magenta;
            this.tsslbTrainingSecsPass.Name = "tsslbTrainingSecsPass";
            this.tsslbTrainingSecsPass.Size = new System.Drawing.Size(464, 25);
            this.tsslbTrainingSecsPass.Spring = true;
            this.tsslbTrainingSecsPass.Text = "0";
            this.tsslbTrainingSecsPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslblDate
            // 
            this.tsslblDate.AutoSize = false;
            this.tsslblDate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslblDate.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.tsslblDate.Name = "tsslblDate";
            this.tsslblDate.Size = new System.Drawing.Size(200, 25);
            // 
            // timerDateView
            // 
            this.timerDateView.Tick += new System.EventHandler(this.timerDateView_Tick);
            // 
            // ucPicChoicePileMain
            // 
            this.ucPicChoicePileMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPicChoicePileMain.Location = new System.Drawing.Point(0, 0);
            this.ucPicChoicePileMain.Name = "ucPicChoicePileMain";
            this.ucPicChoicePileMain.Size = new System.Drawing.Size(1135, 750);
            this.ucPicChoicePileMain.TabIndex = 0;
            // 
            // DlgPicChoicePileBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 750);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.ucPicChoicePileMain);
            this.Name = "DlgPicChoicePileBase";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "看图选意（桩号）";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DlgPicChoicePileNumber_Load);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning.UcPicChoicePileMain ucPicChoicePileMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslblUserName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslbRightsCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslblDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsslbErrsCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tsslbTrainingSecsPass;
        private System.Windows.Forms.Timer timerDateView;

    }
}