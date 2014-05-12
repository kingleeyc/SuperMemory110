using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Common;

namespace SuperMemory.Views.Forms.Common
{
    public partial class DlgTrainningBase : Form,ISecTickerView, ITrainningResultView
    {
        public DlgTrainningBase()
        {
            InitializeComponent();
        }
    
        #region ISecTickerView 成员

        void  ISecTickerView.setSec(int sec)
        {
            this.curTrainningSecPass = sec;
            this.updateTrainningSecPassView();
        }

        #endregion

        #region ITrainningResultView 成员

        void ITrainningResultView.updateCrrtCount(int crrtCount)
        {
            this.crrtCount = crrtCount;
            this.updateCrrtCountDo();
        }

        private int crrtCount;
        void ITrainningResultView.updateErrCount(int errCount)
        {
            this.errCount = errCount;
            this.updateErrCountDo();
        }
        private int errCount;
        #endregion

        private delegate void updateTrainningSecPassViewDele();
        private void updateTrainningSecPassView()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new updateTrainningSecPassViewDele(this.updateTrainningSecPassView));
                return;
            }
            this.tsslbTrainingSecsPass.Text = this.curTrainningSecPass.ToString();
        }
        private int curTrainningSecPass;

        private delegate void updateCrrCountDoDele();
        private void updateCrrtCountDo()
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new updateCrrCountDoDele(this.updateCrrtCountDo));
                return;
            }
            this.tsslbRightsCount.Text = this.crrtCount.ToString();

        }

        private delegate void updateErrCountDoDele();
        private void updateErrCountDo()
        {
            if(this.InvokeRequired)                
            {
                this.Invoke(new updateErrCountDoDele(this.updateErrCountDo));
                return;
            }
            this.tsslbErrsCount.Text = this.errCount.ToString();
        }

        private void timerDateView_Tick(object sender, EventArgs e)
        {
            // 更新时间显示
            tsslblDate.Text = DateTime.Now.GetDateTimeFormats('F')[0].ToString();
        }

        private void DlgTrainningBase_Load(object sender, EventArgs e)
        {
            this.timerDateView.Start();
        }
    

}
}