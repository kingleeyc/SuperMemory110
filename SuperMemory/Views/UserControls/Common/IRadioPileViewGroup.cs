using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Views.UserControls.Common
{
    public interface IRadioPileViewGroup
    {
        void onOneRadioChoice(int radioId, IPileView pileView);
    }
}
