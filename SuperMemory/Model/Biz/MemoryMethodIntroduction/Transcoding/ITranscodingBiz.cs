using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Common;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding
{
    interface ITranscodingBiz
    {
        CTrainningSet TrainningSet
        {
            get;
        }
    }
}
