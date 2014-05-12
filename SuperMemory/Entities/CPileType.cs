using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Entities
{
    public class CPileType
    {
        /// <summary>
        /// 类别id
        /// </summary>
        private string pileTypeId;

        public string PileTypeId
        {
            get { return pileTypeId; }
            set { pileTypeId = value; }
        }

        /// <summary>
        /// 类别名称
        /// </summary>
        private string pileTypeName;

        public string PileTypeName
        {
            get { return pileTypeName; }
            set { pileTypeName = value; }
        }

        /// <summary>
        /// 上级类别 id
        /// </summary>
        private string parentTypeId;

        public string ParentTypeId
        {
            get { return parentTypeId; }
            set { parentTypeId = value; }
        }

        /// <summary>
        /// 是否叶子类别
        /// </summary>
        private bool isLeaf;

        public bool IsLeaf
        {
            get { return isLeaf; }
            set { isLeaf = value; }
        }

        /// <summary>
        /// 顺序
        /// </summary>
        private int typeOrder;

        public int TypeOrder
        {
            get { return typeOrder; }
            set { typeOrder = value; }
        }
    }
}
