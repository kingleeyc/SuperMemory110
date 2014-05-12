using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding
{
    interface IGroupsMgr
    {
        void resetCurGroup();
        void nextGroup();
        void nextPileInCurGroup();
        bool isCurGroupFinish();

        ITranscodingPanel TranscodingPanel
        {
            set;
            get;
        }

        IPileGroupView AskPilesGroupView
        {
            get;
            set;
        }

        IPileGroupView AnswerPilesGroupView
        {
            get;
            set;
        }

        IPilesMgr PilesMgr
        {
            set;
        }
    }
}
