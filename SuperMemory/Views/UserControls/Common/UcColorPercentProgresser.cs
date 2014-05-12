using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.UserControls.Common
{
    public partial class UcColorPercentProgresser : UserControl
    {
        public UcColorPercentProgresser()
        {
            InitializeComponent();
        }

        private int progressPercentValue;

        public int ProgressPercentValue
        {
            get { return progressPercentValue; }
            set { 
                progressPercentValue = value;
                this.updateView();
            }
        }

        private void updateView()
        {
            this.updateValueText();
            this.updateForceColorWidth();
        }

        private void updateForceColorWidth()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private void updateValueText()
        {
            //this.progressPercentValue.ToString()
        }
    }
}
