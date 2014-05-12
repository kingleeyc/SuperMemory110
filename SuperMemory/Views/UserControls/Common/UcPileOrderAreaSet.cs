using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Utils;

namespace SuperMemory.Views.UserControls.Common
{
    public partial class UcPileOrderAreaSet : UserControl
    {
        public UcPileOrderAreaSet()
        {
            InitializeComponent();
        }

        public void setObserver(IPileOrderAreaSetObserver ob)
        {
            this.ob = ob;
        }

        internal void updateOrderAreaData(int iBegin, int iEnd)
        {
            this.tbPileOrderBegin.Text = iBegin.ToString();
            this.tbPileOrderEnd.Text = iEnd.ToString();

        }

        private IPileOrderAreaSetObserver ob;

        private void tbPileOrderBegin_TextChanged(object sender, EventArgs e)
        {
            if(!this.validOrderBeginInput())
            {
                return;
            }
            ob.onOrderBeginChanged(this.getCurOrderBegin());
        }

        private bool validOrderBeginInput()
        {
            return CStringUtils.Inst.isNumber(getOrderBeginInput());
        }

        private int getCurOrderBegin()
        {
            return int.Parse(getOrderBeginInput());
        }

        private void tbPileOrderEnd_TextChanged(object sender, EventArgs e)
        {
            if(!this.validOrderEndInput())
            {
                return;
            }
            ob.onOrderEndChanged(this.getCurOrderEnd());
        }

        private int getCurOrderEnd()
        {
            return int.Parse(getOrderEndInput());
        }

        private bool validOrderEndInput()
        {
            return CStringUtils.Inst.isNumber(getOrderEndInput());
        }

        private string getOrderBeginInput()
        {
            return this.tbPileOrderBegin.Text;
        }

        private string getOrderEndInput()
        {
            return this.tbPileOrderEnd.Text;
        }


    }
}
