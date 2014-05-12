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
    public partial class FormFlashCardGear : BaseDockingForm
    {
        public FormFlashCardGear()
        {
            InitializeComponent();
        }

        private void FormFlashCardGear_Load(object sender, EventArgs e)
        {
            this.ucPilesFlashCardGear.initLoad();
        }
    }
}