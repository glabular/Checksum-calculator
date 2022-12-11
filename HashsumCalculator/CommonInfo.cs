using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashsumCalculator
{
    internal static class CommonInfo
    {
		private static bool _eatRAM;
		private static bool _enableStopwatch;

		public static bool EatRAM
		{
			get => _eatRAM;
			set => _eatRAM = value;
		}

        public static bool EnableStopwatch
        {
            get => _enableStopwatch;
            set => _enableStopwatch = value;
        }

        


    }
}
