using Layer1.VIEWMODEL.StudentVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.SERVICES.Abstract
{

    /// <summary>
    ///     The AddStudent Service Interface
    /// </summary>
    public interface IAddStudentService
    {
        /// <summary>
        /// Gets the Student by identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        AddStudentViewModel GetStudentById(long id);

        /// <summary>
        /// Get All Students
        /// </summary>
        /// <returns></returns>
        List<ProfileStudentViewModel> GetAllStudentsWithoutParam();

        /// <summary>
        ///  Adds the student
        /// </summary>
        /// <param name="addStudentModel"></param>
        /// <returns></returns>
        int AddStudent(AddStudentViewModel addStudentModel);

        /// <summary>
        /// Update the Student details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateStudentModel"></param>
        /// <returns></returns>
        int UpdateStudent(long id, AddStudentViewModel updateStudentModel);

        /// <summary>
        /// Delete the Student by identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteStudent(long id);
    }
}
