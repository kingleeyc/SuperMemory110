using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayControl
{
    public interface IPlayControlObserver
    {
        void onPlayOrPauseClick();

        void onStopClick();
    }
}
