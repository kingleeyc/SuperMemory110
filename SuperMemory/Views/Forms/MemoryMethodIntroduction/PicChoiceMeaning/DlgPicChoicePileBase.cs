using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning;
using SuperMemory.Model;

namespace SuperMemory.Views.Forms.MemoryMethodIntroduction.PicChoiceMeaning
{
    public partial class DlgPicChoicePileBase : Form, IFormPicChoice, ISecTickerView
    {
        public DlgPicChoicePileBase()
        {
            InitializeComponent();
        }


        private CPicChoiceMeaningBiz Biz
        {
            get {
                return CModelMgr.Inst.Biz.MemoryMethodIntroduction.PicChoiceMeaning;
            }
        }

        private void DlgPicChoicePileNumber_Load(object sender, EventArgs e)
        {
            this.ucPicChoicePileMain.ChoiceType = this.getChoiceType();
            Biz.CurChoiceForm = this;

            this.ucPicChoicePileMain.initLoad();

            this.fadeOutPrompt = new FadeOutPromptChoiceResult();
            this.fadeOutPrompt.Show(this);
            this.fadeOutPrompt.Location = this.getFadePromptLocation();

            this.timerDateView.Start();
        }

        private void timerDateView_Tick(object sender, EventArgs e)
        {
            // 更新时间显示
            tsslblDate.Text = DateTime.Now.GetDateTimeFormats('F')[0].ToString();
        }

        virtual protected int getChoiceType()
        {
            return -1;
        }


        private Point getFadePromptLocation()
        {
            return new Point(this.Location.X + (this.Size.Width - fadeOutPrompt.Size.Width) / 2, this.Location.Y + this.Size.Height - fadeOutPrompt.Height - 100);
        }

        protected override void OnClosed(EventArgs e)
        {
            this.fadeOutPrompt.Close();
            this.timerDateView.Stop();
            this.timerDateView.Dispose();

            Biz.closeTraining(); 

            base.OnClosed(e);
        }
        

        #region IFormPicChoice 成员

        void IFormPicChoice.showRightPrompt()
        {
            this.fadeOutPrompt.promptRight();
        }
        
        void IFormPicChoice.showErrPrompt()
        {
            this.showErrPrompConcrect();

        }

        void IFormPicChoice.updateCountCorrect(int count)
        {
            this.tsslbRightsCount.Text = count.ToString();
        }

        void IFormPicChoice.updateCountErr(int count)
        {
            this.countErr = count;
            this.updateCountErrConcrect();
        }
        private delegate void updateCountErrConcrectDele();
        private void updateCountErrConcrect()
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new updateCountErrConcrectDele(this.updateCountErrConcrect));
                return;
            }
            this.tsslbErrsCount.Text = this.countErr.ToString();
        }
        private int countErr = 0;


        private delegate void showErrPromptDele();
        private void showErrPrompConcrect()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new showErrPromptDele(this.showErrPrompConcrect));
                return;
            }
            this.fadeOutPrompt.promptErr();
        }


        void IFormPicChoice.showReportDailog(SuperMemory.Entities.CPicChoiceMeaningReport reportData)
        {
            DlgReportTrainning dlgReport = new DlgReportTrainning();
            dlgReport.TrainningType = this.getTrainningTypeName();
            dlgReport.ReportData = reportData;
            dlgReport.ShowDialog(this);
        }

        private string getTrainningTypeName()
        {
            string ret = "看图选义-" + Biz.CurPileType.PileTypeName;
            switch(this.getChoiceType())
            {
            case CChoicesMgr.CHOICE_TYPE_NUMBER:
                return ret  + "(桩号)";
            case CChoicesMgr.CHOICE_TYPE_WORD:
                return ret + "(谐音)";
            case CChoicesMgr.CHOICE_TYPE_ROLE:
                return ret + "(主角)";
            case CChoicesMgr.CHOICE_TYPE_ACTION:
                return ret + " (动作 )";
            }
            return "";
        }
        #endregion

        #region ISecTickerView 成员

        void ISecTickerView.setSec(int sec)
        {
            this.curTrainningSecPass = sec;
            this.updateTrainningSecPassView();
        }
        private delegate void updateTrainningSecPassViewDele();
        private void updateTrainningSecPassView()
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new updateTrainningSecPassViewDele(this.updateTrainningSecPassView));
                return;
            }
            this.tsslbTrainingSecsPass.Text = this.curTrainningSecPass.ToString();
        }
        private int curTrainningSecPass;
        #endregion

        private FadeOutPromptChoiceResult fadeOutPrompt;


    }
}