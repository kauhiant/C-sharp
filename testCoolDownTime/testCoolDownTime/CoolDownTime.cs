﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCoolDownTime
{
    class CoolDownTime
    {
        private DateTime last;
        private TimeSpan ts;
        private double cdTime;

        public CoolDownTime(double cd) {
            cdTime = cd;
        }
        public void record() {
            last = DateTime.Now;
        }
        public bool isCoolDown() {
            ts = DateTime.Now - last;
            return ts.TotalSeconds < cdTime;
        }
        public bool isNotCoolDown() {
            ts = DateTime.Now - last;
            return ts.TotalSeconds >= cdTime;
        }
    }
}
