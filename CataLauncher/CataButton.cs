/* 
    Cata Launcher
    Copyright (C) 2011-2013  Mitchell Kutchuk

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CataLauncher
{
    public partial class CataButton : UserControl
    {
        public CataButton()
        {
            InitializeComponent();
        }


        protected string buttonText = "";

        [Category("Cata Button Properties")]
        public string ButtonText
        {
            get
            {
                return buttonText;
            }
            set
            {
                buttonText = value;
            }
        }

        protected Font bFont = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);

        [Category("Cata Button Properties")]
        public Font ButtonFont
        {
            get
            {
                return bFont;
            }
            set
            {
                bFont = value;
            }
        }

        protected Color bColor = Color.FromArgb(217, 148, 9);

        [Category("Cata Button Properties")]
        public Color ButtonColor
        {
            get
            {
                return bColor;
            }
            set
            {
                bColor = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Font f = ButtonFont;
            Brush brush = new SolidBrush(ButtonColor);

            Graphics g = e.Graphics;

            Size textSize = g.MeasureString(buttonText, f).ToSize();

            g.DrawImage(Properties.Resources.SmallButton, new Rectangle(0, 0, this.Width, this.Height));
            g.DrawString(ButtonText, f, brush, (this.Width - textSize.Width) / 2, (this.Height - textSize.Height) / 2);

        }

    }
}
