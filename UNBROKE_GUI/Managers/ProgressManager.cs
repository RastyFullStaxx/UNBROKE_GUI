using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNBROKE_GUI.Managers
{
    internal class ProgressManager
    {
        private Guna.UI2.WinForms.Guna2CircleProgressBar needsProgressBar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar wantsProgressBar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar savingsProgressBar;

        private int needsTarget;
        private int wantsTarget;
        private int savingsTarget;

        private int needsProgress;
        private int wantsProgress;
        private int savingsProgress;

        public ProgressManager(Guna.UI2.WinForms.Guna2CircleProgressBar needsProgressBar,
                                 Guna.UI2.WinForms.Guna2CircleProgressBar wantsProgressBar,
                                 Guna.UI2.WinForms.Guna2CircleProgressBar savingsProgressBar)
        {
            this.needsProgressBar = needsProgressBar;
            this.wantsProgressBar = wantsProgressBar;
            this.savingsProgressBar = savingsProgressBar;
        }
        public ProgressManager(
                         Guna.UI2.WinForms.Guna2CircleProgressBar savingsProgressBar)
        {
            this.savingsProgressBar = savingsProgressBar;
        }

        public void InitializeTargets(int needsTarget, int wantsTarget, int savingsTarget)
        {
            this.needsTarget = needsTarget;
            this.wantsTarget = wantsTarget;
            this.savingsTarget = savingsTarget;
        }
        public void InitializeTargets( int savingsTarget)
        {;
            this.savingsTarget = savingsTarget;
        }


        public void SetMaximumValues()
        {
            needsProgressBar.Maximum = 100;
            wantsProgressBar.Maximum = 100;
            savingsProgressBar.Maximum = 100;
        }
        public void SetMaximumValues1()
        {
            savingsProgressBar.Maximum = 100;
        }

        public void UpdateProgress()
        {
            if (needsProgress < needsTarget)
            {
                needsProgress++;
                needsProgressBar.Value = needsProgress;
                needsProgressBar.FillColor = needsProgress > 100 ? Color.Purple : Color.White;
            }

            if (wantsProgress < wantsTarget)
            {
                wantsProgress++;
                wantsProgressBar.Value = wantsProgress;
                wantsProgressBar.FillColor = wantsProgress > 100 ? Color.Orange : Color.White;
            }

            if (savingsProgress < savingsTarget)
            {
                savingsProgress++;
                savingsProgressBar.Value = savingsProgress;
                savingsProgressBar.FillColor = savingsProgress > 100 ? Color.Aqua : Color.White;
            }
        }
        public void UpdateProgress1()
        {

            if (savingsProgress < savingsTarget)
            {
                savingsProgress++;
                savingsProgressBar.Value = savingsProgress;
                savingsProgressBar.FillColor = savingsProgress > 100 ? Color.Aqua : Color.White;
            }
        }

        public bool AllProgressReachedTargets()
        {
            return needsProgress >= needsTarget && wantsProgress >= wantsTarget && savingsProgress >= savingsTarget;
        }

        public bool AllProgressReachedTargets1()
        {
            return savingsProgress >= savingsTarget;
        }
    }
}
