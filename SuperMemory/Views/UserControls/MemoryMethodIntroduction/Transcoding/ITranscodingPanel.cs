using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding
{
    public interface ITranscodingPanel
    {
        void showResetGroupPromp();

        void showContinueNextGroupPrompt();

        void showTrainningFinishPrompt();

        void cleanAllPilesMark();
    }
}
