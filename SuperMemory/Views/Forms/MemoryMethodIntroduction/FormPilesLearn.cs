using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Views.Forms.Common;

namespace SuperMemory.Views.Forms.MemoryMethodIntroduction
{
    public partial class FormPilesLearn : BaseDockingForm
    {
        public FormPilesLearn()
        {
            InitializeComponent();
        }

        private void FormPilesLearn_Load(object sender, EventArgs e)
        {
            this.ucPielsLearn.initLoad();
        }
    }
}

