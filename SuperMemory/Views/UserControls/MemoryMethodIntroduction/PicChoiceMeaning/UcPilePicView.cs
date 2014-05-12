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
    public partial class UcPilePicView : UserControl, IPilePicView
    {
        public UcPilePicView()
        {
            InitializeComponent();
        }

        #region IPilePicView 成员

        void IPilePicView.setPic(Image image)
        {
            this.picbPile.Image = image;
        }

        #endregion

        internal void clean()
        {
            this.picbPile.Image = null;
        }
    }
}
