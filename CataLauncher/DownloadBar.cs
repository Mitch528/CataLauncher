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
    public partial class DownloadBar : UserControl
    {
        public DownloadBar()
        {
            InitializeComponent();
        }


        public enum DownloadBarState
        {
            Setup,
            Available,
            Playable
        }

        protected double percent = 0.0f;

        [Category("Download Bar Properties")]
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

                this.Invalidate();
            }
        }

        protected DownloadBarState dBarState = DownloadBarState.Setup;

        [Category("Download Bar Properties")]
        public DownloadBarState BarState
        {
            get
            {
                return dBarState;
            }
            set
            {
                dBarState = value;

                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            switch (dBarState)
            {
                case DownloadBarState.Setup:
                    g.DrawImage(Properties.Resources.dbar_setup, 0, 0);
                    g.DrawImage(Properties.Resources.red_progressbar, 5, 35, (int)((Value / 100) * this.Width), 10);
                    break;

                case DownloadBarState.Available:
                    g.DrawImage(Properties.Resources.dbar_available, 0, 0);
                    g.DrawImage(Properties.Resources.yellow_progressbar, 5, 35, (int)((Value / 100) * this.Width), 10);
                    break;

                case DownloadBarState.Playable:
                    g.DrawImage(Properties.Resources.dbar_playable, 0, 0);
                    g.DrawImage(Properties.Resources.DownloadProgressBarGreen, 5, 35, (int)((Value / 100) * this.Width), 10);
                    break;
            }
        }
    }
}
