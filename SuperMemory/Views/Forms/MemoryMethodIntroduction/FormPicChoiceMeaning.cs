using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.Forms.MemoryMethodIntroduction
{
    public partial class FormPicChoiceMeaning : SuperMemory.Views.Forms.Common.BaseDockingForm
    {
        public FormPicChoiceMeaning()
        {
            InitializeComponent();
        }

        private void FormPicChoiceMeaning_Load(object sender, EventArgs e)
        {
            this.ucPicChoiceMeaningSetting.initLoad();
        }
    }
}

