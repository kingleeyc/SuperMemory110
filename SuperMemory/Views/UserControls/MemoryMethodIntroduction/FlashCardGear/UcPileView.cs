using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Entities;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear;
using SuperMemory.Global;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear.PlayControl;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear
{
    public partial class UcPileView : UserControl
    {
        public UcPileView()
        {
            InitializeComponent();
        }

        private CPile pileData;

        public CPile PileData
        {
            get { return pileData; }
            set { 
                pileData = value;
                this.updatePicView();
            }
        }
        private delegate void updatePicViewDele();
        private void updatePicView()
        {    
            if(this.InvokeRequired)
            {
                this.Invoke(new updatePicViewDele(updatePicView));
                return ;
            }

            if (null == this.pileData)
            {
                return;
            }

            this.picbPile.Image = this.getPicImgFromAddr(this.pileData.Pic);

        }

        //private void RefreshMe()
        //{
        //    this.Refresh();
        //    Application.DoEvents();
        //}

        private void cleanView()
        {
            this.picbPile.Visible = false;
            this.picbPile.Image = null;

            this.lbText.Visible = false;
            this.lbText.Text = "";
        }

        private Image getPicImgFromAddr(string imgAddr)
        {
            return Image.FromFile(CGlobal.Inst.PilePicDir + imgAddr);
        }

        private delegate void switch2StepDele(int step);
        internal void switch2Step(int step)
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new switch2StepDele(switch2Step), new object[] { step});
                return;
            }

            switch(step)
            {
                case (int)EnumPlayPileSteps.Number:
                    this.switch2ShowNumber();
                    break;
                case (int)EnumPlayPileSteps.Pic:
                    this.switch2ShowPic();
                    break;
                case (int)EnumPlayPileSteps.Word:
                    this.switch2ShowWord();
                    break;
                case (int)EnumPlayPileSteps.Role:
                    this.switch2ShowRole();
                    break;
                case (int)EnumPlayPileSteps.Action:
                    this.switch2ShowAction();
                    break;
            }
        }

        private void switch2ShowNumber()
        {
            this.visibleLable();
            this.lbText.ForeColor = Color.Green;
            this.lbText.Text = this.pileData.PileNumber;
        }
        private void switch2ShowPic()
        {
           this.visiblePic();
           //this.RefreshMe();
        }

        private void switch2ShowWord()
        {
            this.visibleLable();
            this.lbText.ForeColor = Color.Blue;
            this.lbText.Text = this.pileData.Word;

            //this.RefreshMe();
        }

        private void switch2ShowRole()
        {
            this.visibleLable();
            this.lbText.ForeColor = Color.Red;
            this.lbText.Text = this.pileData.Role;

            //this.RefreshMe();
        }

        private void switch2ShowAction()
        {
            this.visibleLable();
            this.lbText.ForeColor = Color.Fuchsia;
            this.lbText.Text = this.pileData.Action;

            //this.RefreshMe();
        }

        private void visibleLable()
        {
            this.picbPile.Visible = false;
            this.lbText.Visible = true;
        }

        private void visiblePic()
        {
            this.picbPile.Visible = true;
            this.lbText.Visible = false;
        }

    }
}
