using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_attendance_Project.Core
{
    public interface IServiceLocator
    {
        ICoursesService GetCoursesService();

        IUsersService GetUsersService();

        IAuthenticationManager GetAuthenticationManager();
        
    }
}
