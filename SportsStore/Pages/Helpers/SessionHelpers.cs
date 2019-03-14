using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace SportsStore.Pages.Helpers
{
    public enum SessionKey
    {
        CART,
        RETURN_URL
    }

    public static class SessionHelpers
    {
        public static void Set(HttpSessionState session, SessionKey key, object value)
        {
            session[Enum.GetName(key] = value;
        }
    }
}