using Layer1.VIEWMODEL.ClassVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.SERVICES.Abstract
{
   public interface IClassService
    {
        List<ProfileClassViewModel> GetAllClassWithoutParam();
        int AddClass(AddClassViewModel addClassModel);
        int DeleteClass(long id);
    }
}
