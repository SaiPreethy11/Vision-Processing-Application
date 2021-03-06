﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProcessing2._0
{
    public class DataHolder
    {
        public DataHolder() { }

        public double brightness;
        public double exposure;
        public double focus;
        public double fps;

        public double lhue;
        public double uhue;
        public double lsat;
        public double usat;
        public double lval;
        public double uval;

        public int medianTolerance = 1;

        public string NetworkTablesAddress;

        public double minBrightness;
        public double maxBrightness;
        public double minExposure;
        public double maxExposure;
        public double minFocus;
        public double maxFocus;

        public List<double> ratio = new List<double>();
        public bool filter;
    }
}
