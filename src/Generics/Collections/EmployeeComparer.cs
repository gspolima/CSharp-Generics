using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Collections
{
    class EmployeeComparer : IEqualityComparer<Employee>, IComparer<Employee>
    {
        public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
        {
            return string.Compare(x.Name, y.Name);
        }

        public bool Equals([AllowNull] Employee x, [AllowNull] Employee y)
        {
            return string.Equals(x.Name, y.Name);
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
