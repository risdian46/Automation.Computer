﻿using System.Collections.Generic;

using TechTalk.SpecFlow;

namespace Automation.Framework.Core.Utils
{
    public class TableExtensions
    {
        public static Dictionary<string, string> ToDictionary(Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            return dictionary;
        }

    }
}
