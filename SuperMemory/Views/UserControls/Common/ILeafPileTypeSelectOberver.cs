using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Views.UserControls.Common
{
    public interface ILeafPileTypeSelectOberver
    {
        void onPileTypeSelectChanged(CPileType curPileType);
    }
}
