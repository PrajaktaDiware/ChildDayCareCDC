using Layer1.VIEWMODEL.StudentVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.SERVICES.Abstract
{
 
    public interface IAddStudentService
    {
        AddStudentViewModel GetStudentById(long id);
        List<ProfileStudentViewModel> GetAllStudentsWithoutParam();
        int AddStudent(AddStudentViewModel addStudentModel);
        int UpdateStudent(long id, AddStudentViewModel updateStudentModel);

        int DeleteStudent(long id);
    }
}
