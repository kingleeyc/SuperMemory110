using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding;
using SuperMemory.Views.UserControls.Common;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Common;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding
{
    interface IAnswerVerifier
    {
        IPileView CurChosenAnswerPile
        {
            get;
            set;
        }

        IPileView CurChosenAskPile
        {
            set;
            get;
        }

        CTrainningResult TrainningResult
        {
            get;
        }

        ITranscodingPanel TranscodingPanel
        {
            set;
        }

        IGroupsMgr GroupsMgr
        {
            set;
        }

        IPilesMgr PilesMgr
        {
            set;
        }

        ISecTickerView GroupCountDownView
        {
            set;
        }

        ISecTickerView TrainningTimingView
        {
            set;
        }

        void verifyDo();

        void beginTrainning();
    }
}
