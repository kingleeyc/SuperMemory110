using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Entities;

namespace SuperMemory.Views.Forms.MemoryMethodIntroduction.PicChoiceMeaning
{
    public partial class DlgReportTrainning : Form
    {
        public DlgReportTrainning()
        {
            InitializeComponent();
        }

        private CPicChoiceMeaningReport reportData;

        public CPicChoiceMeaningReport ReportData
        {
            get { return reportData; }
            set { reportData = value; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DlgReportTrainning_Load(object sender, EventArgs e)
        {
            this.lbTrainningType.Text = this.trainningType;
            this.lbTotalAmount.Text = this.reportData.TotalQuestionsAmount.ToString();
            this.lbCorrectAmount.Text = this.reportData.CorrectAmount.ToString();
            this.lbErrAmount.Text = this.reportData.ErrAmout.ToString();
            this.lbSecUsed.Text = this.reportData.TotalSecUsed.ToString();
            this.lbReportTime.Text = this.reportData.ReportDateTime;
        }

        private string trainningType;

        public string TrainningType
        {
            set { trainningType = value; }
        }
    }
}