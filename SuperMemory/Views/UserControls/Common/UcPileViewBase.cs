using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Entities;
using SuperMemory.Enums;
using SuperMemory.Global;

namespace SuperMemory.Views.UserControls.Common
{
    public partial class UcPileViewBase : UserControl, IPileView
    {
        public UcPileViewBase()
        {
            InitializeComponent();
        }

        private void UcPileViewBase_Load(object sender, EventArgs e)
        {
            this.curEnabelContol = this.lbPile;
        }
        private Control curEnabelContol;

        private void lbPile_MouseClick(object sender, MouseEventArgs e)
        {
            onPileClick(e);        }

        private void onPileClick(MouseEventArgs e)
        {
            if (null == this.pileData)
            {
                return;
            }
            this.chooseMe();
            this.bkg2Chosen();

            // 传递事件到父控件
            this.OnMouseClick(e);
        }

        private void lbPile_MouseEnter(object sender, EventArgs e)
        {
            onMouseEnterPile();
        }

        private void onMouseEnterPile()
        {
            if (this.bIsChosen)
            {
                return;
            }
            this.bkg2MouseOn();
        }

        private void lbPile_MouseLeave(object sender, EventArgs e)
        {
            onMouseLeavePile();
        }

        private void onMouseLeavePile()
        {
            if (this.bIsChosen)
            {
                return;
            }
            this.bkg2prim();
        }

        private void picbPile_MouseClick(object sender, MouseEventArgs e)
        {
            onPileClick(e);
        }

        private void picbPile_MouseEnter(object sender, EventArgs e)
        {
            onMouseEnterPile();
        }

        private void picbPile_MouseLeave(object sender, EventArgs e)
        {
            onMouseLeavePile();
        }
        
        internal void bkg2Chosen()
        {
            this.curEnabelContol.BackColor = this.clrBkgChosen;
        }

        internal void bkg2MouseOn()
        {
            this.curEnabelContol.BackColor = this.clrBkgMouseOn;
        }

        internal void bkg2prim()
        {
            this.curEnabelContol.BackColor = this.clrBkgPrim;
        }

       
        public string LbText
        {
            set { 
                this.lbPile.Text = value;
            }
        }

        private Color clrBkgPrim = Color.LightGray;
        private Color clrBkgMouseOn = Color.YellowGreen;
        private Color clrBkgChosen = Color.Yellow;







        #region IPileView 成员

        void IPileView.cleanData()
        {
            (this as IPileView).PileData = null;
            (this as IPileView).cleanMark();
            (this as IPileView).unChoice();
        }

        void IPileView.unChoice()
        {
            this.bIsChosen = false;
            this.bkg2prim();
        }

        void IPileView.markCorrect()
        {
            this.picbMark.Visible = true;
            this.picbMark.Image = global::SuperMemory.Properties.Resources.dialog_apply;
        }

        void IPileView.markError()
        {
            this.picbMark.Visible = true;
            this.picbMark.Image = global::SuperMemory.Properties.Resources.dialog_cancel_3;
        }

        void IPileView.cleanMark()
        {
            this.cleanMarkImpl();
        }


        private CPile pileData = null;
        CPile IPileView.PileData
        {
            get { return this.pileData; }
            set
            {
                this.pileData = value;
                this.updatePileView();
            }
        }

        EnumPileDataFiled IPileView.DataViewFiled
        {
            get
            {
                return this.dataViewFiled;
            }
            set
            {
                this.dataViewFiled = value;
            }
        }
        private EnumPileDataFiled dataViewFiled = EnumPileDataFiled.number;

        #endregion

        private void chooseMe()
        {
            this.bIsChosen = true;
        }

        private delegate void updatePileViewDele();
        private void updatePileView()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new updatePileViewDele(this.updatePileView));
                return;
            }

            if (null == this.pileData)
            {
                //(this as IPileView).cleanMark();
                this.cleanMarkImpl();
                //this.ucPileViewBase.LbText = "";
                //
                this.cleanDataView();
                this.closeChooseHandle();
                return;
            }
            //this.lbPile.Text = this.pileData.PileNumber;
            this.openChooseHandle();

            this.viewDataDo();
            //this.lbPile.Text = this.pileData.PileNumber;
        }

        private void viewDataDo()
        {
            switch((int)this.dataViewFiled)
            {
                case (int)EnumPileDataFiled.number:
                    this.switch2TextView();
                    this.lbPile.Text = pileData.PileNumber;
                    break;
                case (int)EnumPileDataFiled.word:
                    this.switch2TextView();
                    this.lbPile.Text = pileData.Word;
                    break;
                case (int)EnumPileDataFiled.pic:
                    this.switch2PicView();
                    this.picbPile.Image = Image.FromFile(CGlobal.Inst.PilePicDir + pileData.Pic);
                    break;
                case (int)EnumPileDataFiled.role:
                    this.switch2TextView();
                    this.lbPile.Text = pileData.Role;
                    break;
                case (int)EnumPileDataFiled.action:
                    this.switch2TextView();
                    this.lbPile.Text = pileData.Action;
                    break;
            }
        }

        private void switch2PicView()
        {
            this.picbPile.Visible = true;
            this.lbPile.Visible = false;
            this.curEnabelContol = this.picbPile;
        }

        private void switch2TextView()
        {
            this.picbPile.Visible = false;
            this.lbPile.Visible = true;
            this.curEnabelContol = this.lbPile;
        }

        private void cleanDataView()
        {
            this.lbPile.Text = "";
            this.picbPile.Image = null;
        }

        private void cleanMarkImpl()
        {
            this.picbMark.Visible = false;
        }

        private void openChooseHandle()
        {
            this.Enabled = true;
        }

        private void closeChooseHandle()
        {
            this.Enabled = false;
        }

        private bool bIsChosen = false;




    }
}
