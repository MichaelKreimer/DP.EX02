using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C16_Ex02_Michael_305597478_Shai_300518495
{
    public partial class ListBoxProxy : ListBox
    {
        public ListBoxProxy()
        {
            //this.BackColor = Color.Cyan; 
            InitializeComponent();
        }

        public override void ResetBackColor()
        {
            this.BackColor = Color.Green;
        }
    }
}
