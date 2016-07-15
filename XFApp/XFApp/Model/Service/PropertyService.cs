using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace XFApp.Model.Service
{
    class PropertyService
    {
        public static string GetName<T>(Expression<Func<T>> e)
        {
            var member = (MemberExpression)e.Body;
            return member.Member.Name;
        }

    }
}
