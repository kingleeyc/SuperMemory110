using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.Forms.MemoryMethodIntroduction
{
    public partial class FormTranscoding : SuperMemory.Views.Forms.Common.BaseDockingForm
    {
        public FormTranscoding()
        {
            InitializeComponent();
        }

        private void FormTranscoding_Load(object sender, EventArgs e)
        {
            this.ucTranscodingSetting.initLoad();
        }
    }
}

