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
using System.Drawing.Drawing2D;

namespace CataLauncher
{
    public partial class DownloadProgressBar : UserControl
    {
        public DownloadProgressBar()
        {
            InitializeComponent();
        }

        public enum ProgressBarColor
        {
            Green,
            Blue,
            Red,
            Yellow
        }

        protected double percent = 0.0f;

        [Category("Behavior")]
        [DefaultValue(true)]
        public double Value
        {
            get
            {
                return percent;
            }

            set
            {

                if (value < 0)
                    value = 0;
                else if (value > 100)
                    value = 100;

                percent = value;

                progressBarPictureBox.Size = new Size((int)((value / 100) * this.Width), this.Height);

                this.Invalidate();
            }
        }

        public void DownloadColor(ProgressBarColor color)
        {
            switch (color)
            {
                case ProgressBarColor.Green:

                    progressBarPictureBox.BackgroundImage = Properties.Resources.DownloadProgressBarGreen;

                    break;
            }
        }

    }
}
