﻿using System;
using System.Collections.Generic;

namespace AndaForceUtils.Collections.LinqClone
{
    public static class ClonedLinqSumMethods
    {
        public static Single ClonedSum(this List<Single> list)
        {
            var result = 0.0f;
            foreach (var f in list)
            {
                result += f;
            }

            return result;
        }

        public static Int32 ClonedSum(this List<Int32> list)
        {
            var result = 0;
            foreach (var f in list)
            {
                result += f;
            }

            return result;
        }
    }
}
