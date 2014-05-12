using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SuperMemory.Views.Forms.Common;
using SuperMemory.Views.Forms.MemoryMethodIntroduction;
using SuperMemory.Views.Forms.DataMgr;

namespace SuperMemory
{
    public partial class FormMain : Office2007RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        #region 记忆法入门
        /// <summary>
        /// 110桩学些
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPilesLearn_Click(object sender, EventArgs e)
        {
            showSubForm(this.frmPilesLearn);
        }

        private void btnFlashCardGear_Click(object sender, EventArgs e)
        {
            showSubForm(frmFlashCardGear);
        }
        
        
        private void btnChoosePicSig_Click(object sender, EventArgs e)
        {
            showSubForm(frmChoosePicSig);
        }

        private void btnTranscoding_Click(object sender, EventArgs e)
        {
            showSubForm(frmTranscoding);
        }

        private void btnPilesExam_Click(object sender, EventArgs e)
        {
            showSubForm(frmPilesExam);
        }


        
        FormPilesLearn frmPilesLearn = new FormPilesLearn();
        FormFlashCardGear frmFlashCardGear = new FormFlashCardGear();
        FormPicChoiceMeaning frmChoosePicSig = new FormPicChoiceMeaning();
        FormTranscoding frmTranscoding = new FormTranscoding();
        FormPilesExam frmPilesExam = new FormPilesExam();
        #endregion

        #region 数据
        /// <summary>
        /// 桩库管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPilesDbMgr_Click(object sender, EventArgs e)
        {
            showSubForm(frmPilesDataMgr);
        }

        private FormPilesDataMgr frmPilesDataMgr = new FormPilesDataMgr();

        private void btnExamDataMgr_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void showSubForm(BaseDockingForm frm)
        {
            if (!frm.IsHidden)
            {
                frm.Activate();
                return;
            }

            frm.Show(this.dockPanel);
        }






    }
}