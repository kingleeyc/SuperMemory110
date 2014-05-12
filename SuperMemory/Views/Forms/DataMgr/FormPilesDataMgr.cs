using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.Forms.DataMgr
{
    public partial class FormPilesDataMgr : SuperMemory.Views.Forms.Common.BaseDockingForm
    {
        public FormPilesDataMgr()
        {
            InitializeComponent();
        }

        private void FormPilesDataMgr_Load(object sender, EventArgs e)
        {
            this.ucPilesDataMgr.initLoad();
        }
    }
}

