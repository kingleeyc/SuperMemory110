using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Global
{
    public class CGlobal
    {
        private CGlobal() { }
        private static CGlobal inst = new CGlobal();

        public static CGlobal Inst
        {
            get { return CGlobal.inst; }
        }

        public string PilePicDir
        {
            get {
                return Application.StartupPath + "\\pics\\"; 
            }
        }
    }
}
