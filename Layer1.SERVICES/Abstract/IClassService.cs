using Layer1.VIEWMODEL.ClassVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.SERVICES.Abstract
{
    /// <summary>
    /// The Class Service Interface
    /// </summary>
    public interface IClassService
    {
        /// <summary>
        /// Get all Classes
        /// </summary>
        /// <returns></returns>
        List<ProfileClassViewModel> GetAllClassWithoutParam();

        /// <summary>
        /// Add the Class
        /// </summary>
        /// <param name="addClassModel"></param>
        /// <returns></returns>
        int AddClass(AddClassViewModel addClassModel);

        /// <summary>
        /// Delete the Class by Idntifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteClass(long id);
    }
}
