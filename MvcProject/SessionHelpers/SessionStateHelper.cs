﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProject.SessionHelpers
{
    public enum SessionStateKeys
    {
        NAME
    }
    public static class SessionStateHelper
    {
        public static object Get(SessionStateKeys key)
        {
            string keyString = Enum.GetName(typeof(SessionStateKeys), key);
            return HttpContext.Current.Session[keyString];
        }
        public static object Set(SessionStateKeys key, object value)
        {
            string keyString = Enum.GetName(typeof(SessionStateKeys), key);
            return HttpContext.Current.Session[keyString] = value;
        }
    }
}