using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear.PlayControl.PlayGroupControl;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear.PlayControl
{
    public class CPlayGroupController
    {

        public CPlayGroupController(CPlayController playController)
        {
            this.playController = playController;
            this.playPileContorllersStore = new CPlayPileControllersStore(playController);
            this.playStepController = new CPlayStepController(playController);
        }
        /// <summary>
        /// 重置
        /// </summary>
        internal void reset()
        {
            this.playPileContorllersStore.reset();
            this.playStepController.reset();

            //this.firstGroup();
        }

        internal void firstGroup()
        {
            this.nextGroup();
        }
        /// <summary>
        /// 下一步（桩的下一个属性、字段）
        /// </summary>
        internal void nextStep()
        {
            this.playStepController.nextStep();
            this.view.switch2Step(this.playStepController.CurStep);
        }
        /// <summary>
        /// 是否一组桩的所有步（桩的属性、字段）走完
        /// </summary>
        /// <returns></returns>
        internal bool isStepsFinished()
        {
            return this.playStepController.isStepsFinished();
        }
        /// <summary>
        /// 下一组桩
        /// </summary>
        internal void nextGroup()
        {
            //CPile pile = this.playPileContorllersStore.getPlayPileController().nextPile();
            this.playStepController.reset();
            for (int i = 0; i < this.playController.PlayCondition.PlayGroupAmount; i++)
            {
                this.fill1Pile2PileView(this.playPileContorllersStore.getPlayPileController().nextPile(), i);
            }
        }

        private void fill1Pile2PileView(CPile pile,int index)
        {
            view.setPile(pile,index);
        }


        private IPilesGroupView view;

        public IPilesGroupView View
        {
            get { return view; }
            set { view = value; }
        }


        private CPlayController playController;
        private CPlayStepController playStepController;
        private CPlayPileControllersStore playPileContorllersStore;

    }
}
