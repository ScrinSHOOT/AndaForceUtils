﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndaForceUtils.Collections.Generic.Extension
{
    public static class EnumerableExtension
    {
        public static String PrintElements<T>(this IEnumerable<T> enumerable)
        {
            var items = enumerable.ToArray();
            if (items.Any())
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.Append(String.Format("{0}: {{", typeof (T)));

                foreach (var item in items)
                {
                    stringBuilder.Append(String.Format("[{0}], ", item));
                }
                var result = stringBuilder.ToString();
                result = result.Remove(result.Length - 2);
                result += "}";

                return result;
            }
            return String.Format("{0}", typeof (T));
        }
    }
}