using Layer1.SERVICES.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer1.VIEWMODEL.StudentVM;
using AutoMapper;
using Layer1.ENTITIES.Model;
using Layer1.DATA.Repositories;
using Layer1.DATA.Infrastructure;
using System.Web.Http.Cors;

namespace Layer1.SERVICES.Services
{
    /// <summary>
    /// AddStudent Service
    /// </summary>
    /// <seealso cref="IAddStudentService" />

    //prajakta
    public class AddStudentService : IAddStudentService
    {
        private readonly IEntityBaseRepository<AddStudent> _StudentRepository;
        //private readonly IEntityBaseRepository<ProfileStudent> _ProfileStudentRepository;
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddStudentService"/> class.
        /// </summary>
        /// <param name="StudentRepository"></param>
        /// <param name="ProfileStudentRepository"></param>
        /// <param name="unitOfWork"></param>
        public AddStudentService(
          IEntityBaseRepository<AddStudent> StudentRepository,
           //IEntityBaseRepository<ProfileStudent> ProfileStudentRepository,
          IUnitOfWork unitOfWork
          )
        {
            _StudentRepository = StudentRepository;
            //_ProfileStudentRepository = ProfileStudentRepository;
            _unitOfWork = unitOfWork;

        }

        //Add
        public int AddStudent(AddStudentViewModel addStudentModel)
        {
            //throw new NotImplementedException();
            var studentData = Mapper.Map<AddStudentViewModel, AddStudent>(addStudentModel);

            _StudentRepository.Add(studentData);
            _unitOfWork.Commit();

            return 1;

        }
       
        /// <summary>
        /// Display all the data of student
        /// </summary>
        /// <value>
        /// Get all the data 
        /// </value>
        /// <returns></returns>
        public List<ProfileStudentViewModel> GetAllStudentsWithoutParam()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AddStudent, ProfileStudentViewModel>();
                cfg.CreateMap<ProfileStudentViewModel, AddStudent>();
            });

            var studentdata = _StudentRepository.GetAll().ToList();
            var studentModelData = Mapper.Map<List<AddStudent>, List<ProfileStudentViewModel>>(studentdata);
            return studentModelData;
        }

        /// <summary>
        /// Gets the Student by identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AddStudentViewModel GetStudentById(long id)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AddStudent, AddStudentViewModel>();
                cfg.CreateMap<AddStudentViewModel, AddStudent>();
            });

            var studentByIdData = _StudentRepository.GetSingle(id);
            var studentModelData = Mapper.Map<AddStudent, AddStudentViewModel>(studentByIdData);
            return studentModelData;
        }

        public int UpdateStudent(long id, AddStudentViewModel updateStudentModel)
        {
            var user = _StudentRepository.GetAll().SingleOrDefault(c => c.Id == id);
            var DATA = Mapper.Map<AddStudentViewModel, AddStudent>(updateStudentModel);
            _StudentRepository.Edit(user, DATA); ;
            _unitOfWork.Commit();
            return 1;

        }

        public int DeleteStudent(long id)
                {
                    var studentDetails = _StudentRepository.FindBy(m => m.Id == id && m.IsDeleted == false).FirstOrDefault();
                    if (studentDetails != null)
                     studentDetails.IsDeleted = true;
                    _unitOfWork.Commit();
                    return 1;
                }
         }
    }

