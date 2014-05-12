using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PilesLearn;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction
{
    public class CMemoryMethodIntroductionBiz
    {
        private CPilesLearnBiz pilesLearn = new CPilesLearnBiz();

        public CPilesLearnBiz PilesLearn
        {
            get { return pilesLearn; }
        }

        private CPilesFlashCardGearBiz pilesFlashCardGear = new CPilesFlashCardGearBiz();

        public CPilesFlashCardGearBiz PilesFlashCardGear
        {
            get { return pilesFlashCardGear; }
        }

        private CPicChoiceMeaningBiz picChoiceMeaning = new CPicChoiceMeaningBiz();

        public CPicChoiceMeaningBiz PicChoiceMeaning
        {
            get { return picChoiceMeaning; }
        }

        private CTranscodingBiz transcoding = new CTranscodingBiz();

        internal CTranscodingBiz Transcoding
        {
            get { return transcoding; }
        }

    }
}
