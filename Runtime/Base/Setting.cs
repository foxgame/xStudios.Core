using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace X
{
    public static class Setting
    {
        public static int Version = 1000001;

        public static string GetVersion()
        {
            int mainVer = Version / 1000000;
            int mVer = ( Version / 1000 ) % 1000;
            int sourceVer = Version % 1000;

            return "V " + mainVer + "." + string.Format( "{0:D2}" , mVer ) + "." + string.Format( "{0:D3}" , sourceVer );
        }

    }

}

