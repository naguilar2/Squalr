﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Be.HexEditor.Core
{
    public class ToolStripSplitButtonEx : ToolStripSplitButton, IScalingItem
    {
        System.Drawing.Image _image16;
        [DefaultValue(null)]
        public System.Drawing.Image Image16
        {
            get { return _image16; }
            set { _image16 = value; }
        }

        System.Drawing.Image _image24;
        [DefaultValue(null)]
        public System.Drawing.Image Image24
        {
            get { return _image24; }
            set { _image24 = value; }
        }

        System.Drawing.Image _image32;
        [DefaultValue(null)]
        public System.Drawing.Image Image32
        {
            get { return _image32; }
            set { _image32 = value; }
        }
    }
}
