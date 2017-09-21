using Layer1.SERVICES.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer1.VIEWMODEL;
using AutoMapper;
using Layer1.ENTITIES;
using Layer1.DATA.Repositories;
using Layer1.DATA.Infrastructure;

namespace Layer1.SERVICES.Services
{
    public class StudentService : IStudentService
    {



        private readonly IEntityBaseRepository<CStudent> _StudentRepository;
     
        private readonly IUnitOfWork _unitOfWork;

        public StudentService(
          IEntityBaseRepository<CStudent> StudentRepository,
          IUnitOfWork unitOfWork
          )
        {
            _StudentRepository = StudentRepository;
            _unitOfWork = unitOfWork;
           
        }

        public int AddStudent(CStudentViewModel addstudentmodel)
        {
            var studentData = Mapper.Map<CStudentViewModel, CStudent>(addstudentmodel);

            _StudentRepository.Add(studentData);
            _unitOfWork.Commit();

            return 1;
        }


        public List<CStudent> GetAllStudentsWithoutParam()
        {
            var studentdata = _StudentRepository.GetAll().ToList();
            //var studentModelData = Mapper.Map<List<CStudent>, List<CStudentViewModel>>(studentdata);
            //return studentModelData;
            return studentdata;
        }


        public List<CStudentViewModel> GetAllStudents(CStudentViewModel model)
        {
            var studentdata = _StudentRepository.GetAll().ToList();

            var studentModelData = Mapper.Map<List<CStudent>, List<CStudentViewModel>>(studentdata);
           
            return studentModelData;   
        }


        public CStudentViewModel GetStudentById(long id)
        {
            var studentByIdData = _StudentRepository.GetSingle(id);
            var studentModelData = Mapper.Map<CStudent, CStudentViewModel>(studentByIdData);
            return studentModelData;
        }

        


        ////GetStudentByName for login
        //public CStudentViewModel GetStudentByName(string name)
        //{
        //    var studentByIdData = _StudentRepository.GetSingle(name);
        //    var studentModelData = Mapper.Map<CStudent, CStudentViewModel>(studentByIdData);
        //    return studentModelData;
        //}

        public int UpdateStudent(long id, CStudentViewModel updateStudentModel)
        {
            throw new NotImplementedException();
        }
        public int DeleteStudent(long id)
        {
            throw new NotImplementedException();
        }

    }
}
