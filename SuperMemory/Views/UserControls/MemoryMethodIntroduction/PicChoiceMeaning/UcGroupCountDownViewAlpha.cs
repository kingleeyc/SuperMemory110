using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning
{
    public partial class UcGroupCountDownViewAlpha : UserControl, ISecTickerView
    {
        public UcGroupCountDownViewAlpha()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.BackColor = Color.Transparent;

            InitializeComponent();

            //this.BackColor = Color.FromArgb(100, Color.Red);

        }

        #region ISecTickerView 成员
        
        void ISecTickerView.setSec(int sec)
        {
            this.curSec = sec;
            this.updateSecView();

        }


        
        #endregion
        private delegate void updateSecDele();
        private void updateSecView()
        {
            //
            if (this.InvokeRequired)
            {
                this.Invoke(new updateSecDele(this.updateSecView));
                return;
            }

            this.label1.Text = this.curSec.ToString();
            //
        }

        private int curSec;

        private void UcGroupCountDownView_Load(object sender, EventArgs e)
        {

        }
    }
}
