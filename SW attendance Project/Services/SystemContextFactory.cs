using SW_attendance_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_attendance_Project.Services
{
    public class SystemContextFactory
    {
        public SystemContext GetNewSystemContext()
        {
            return new SystemContext();
        }
    }
}
