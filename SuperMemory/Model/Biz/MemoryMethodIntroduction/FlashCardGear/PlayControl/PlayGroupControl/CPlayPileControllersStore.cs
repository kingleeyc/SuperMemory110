using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using SuperMemory.Model.Biz.Common.PileForwardOrderControl;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear.PlayControl
{
    class CPlayPileControllersStore
    {
        public CPlayPileControllersStore(CPlayController playController)
        {
            this.playController = playController;
            this.createControllers();
        }

        private void createControllers()
        {
            this.controllers = new Hashtable();

            this.controllers.Add((int)EnumPlayPileOrderStates.Forward,new CPileForwardOrderControllerForwardOrder(this.playController));
            this.controllers.Add((int)EnumPlayPileOrderStates.Reverse,new CPileForwardOrderControllerReverseOrder(this.playController));
            this.controllers.Add((int)EnumPlayPileOrderStates.Rand,new CPileForwardOrderControllerRandOrder(this.playController));
        }

        private CPlayController playController;

        internal IPileForwardOrderController getPlayPileController()
        {
            IPileForwardOrderController obj = this.controllers[this.playController.PlayCondition.PlayOrderState] as IPileForwardOrderController;
            return this.controllers[this.playController.PlayCondition.PlayOrderState] as IPileForwardOrderController;
        }

        private Hashtable controllers;

        internal void reset()
        {
            foreach (DictionaryEntry de in this.controllers)
            {
                (de.Value as IPileForwardOrderController).reset();

            }
        }
    }
}
