// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.HttpRepl.Preferences;
using Microsoft.Repl.ConsoleHandling;

namespace Microsoft.HttpRepl.Fakes
{
    public class NullPreferences : IPreferences
    {
        public IReadOnlyDictionary<string, string> CurrentPreferences => null;
        public IReadOnlyDictionary<string, string> DefaultPreferences => null;

        public AllowedColors GetColorValue(string preference, AllowedColors defaultValue = AllowedColors.None)
        {
            return defaultValue;
        }

        public int GetIntValue(string preference, int defaultValue = 0)
        {
            return defaultValue;
        }

        public string GetValue(string preference, string defaultValue = null)
        {
            return defaultValue;
        }

        public bool SetValue(string preference, string value)
        {
            return false;
        }

        public bool TryGetValue(string preference, out string value)
        {
            value = null;
            return false;
        }
    }
}
