using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.Common
{
    public class C2PilesMatchVerifierImpl : I2PilesMatchVerifier
    {
        #region I2PilesMatchVerifier 成员

        CPile I2PilesMatchVerifier.PileLeft
        {
            get
            {
                return this.pileLeft;
            }
            set 
            { 
                this.pileLeft = value;
                this.verifyDo();
            }
        }

        CPile I2PilesMatchVerifier.PileRight
        {
            get
            {
                return this.pileRight;
            }
            set 
            { 
                this.pileRight = value;
                this.verifyDo();
            }
        }

        I2PilesMatchVerifyResultObserver I2PilesMatchVerifier.ResultObserver
        {
            set { this.resultObserver = value; }
        }

        #endregion

        private void verifyDo()
        {
            if(!this.pilesReady())
            {
                return;
            }
            if (this.pileRight.PrimOrder == this.pileLeft.PrimOrder)
            {
                this.onMatchRight();
            }
            else
            {
                this.onMatchFault();
            }
        }

        private void onMatchRight()
        {
            this.notifyMatchRight();
            this.cleanPiles();
        }

        private void onMatchFault()
        {
            this.notifyMatchFault();
            this.cleanPiles();
        }

        private void notifyMatchFault()
        {
            if(null == this.resultObserver)
            {
                return;
            }
            this.resultObserver.onMatchFault();
        }


        private void notifyMatchRight()
        {
            if (null == this.resultObserver)
            {
                return;
            }
            this.resultObserver.onMatchRight();
        }

        private void cleanPiles()
        {
            this.pileLeft = null;
            this.pileRight = null;
        }

        private bool pilesReady()
        {
            if (null == this.pileLeft)
            {
                return false;
            }

            if (null == this.pileRight)
            {
                return false;
            }
            return true;
        }

        private CPile pileLeft = null;
        private CPile pileRight = null;
        private I2PilesMatchVerifyResultObserver resultObserver = null;
    }
}
