﻿using Layer1.ENTITIES;
using Layer1.VIEWMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.SERVICES.Abstract
{
    /// <summary>
    /// The Student Service Interface
    /// </summary>
    public interface IStudentService
    {
        /// <summary>
        /// Get the Student By Identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CStudentViewModel GetStudentById(long id);

        List<CStudentViewModel> GetAllStudents(CStudentViewModel model);
        
        List<CStudent> GetAllStudentsWithoutParam();

        int AddStudent(CStudentViewModel addStudentModel);

        int UpdateStudent(long id, CStudentViewModel updateStudentModel);

        int DeleteStudent(long id);
    }
}
