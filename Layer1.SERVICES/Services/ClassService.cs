using Layer1.SERVICES.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer1.VIEWMODEL.ClassVM;
using Layer1.ENTITIES.Model;
using Layer1.DATA.Repositories;
using Layer1.DATA.Infrastructure;
using AutoMapper;

namespace Layer1.SERVICES.Services
{
    //prajakta

    /// <summary>
    /// AddStudent Service
  
    /// <seealso cref="IAddStudentService" />

    public class ClassService : IClassService
    {fhfchgvxsgxsg
        private readonly IEntityBaseRepository<ProfileClass> _ProfileClassRepository;
        private readonly IEntityBaseRepository<AddClass> _AddClassRepository;
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassService"/> class.
        /// </summary>
        /// <param name="ProfileClassRepository"></param>
        /// <param name="AddClassRepository"></param>
        /// <param name="unitOfWork"></param>
        public ClassService(
          IEntityBaseRepository<ProfileClass> ProfileClassRepository,
          IEntityBaseRepository<AddClass>AddClassRepository,
          IUnitOfWork unitOfWork
          )
        {
            _ProfileClassRepository = ProfileClassRepository;
            _AddClassRepository = AddClassRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Get all the Classes
        /// </summary>
        /// <returns></returns>
        public List<ProfileClassViewModel> GetAllClassWithoutParam()
        {
            var studentdata = _ProfileClassRepository.GetAll().ToList();
            var studentModelData = Mapper.Map<List<ProfileClass>, List<ProfileClassViewModel>>(studentdata);
            return studentModelData;
        }

        /// <summary>
        /// Add the Class
        /// </summary>
        /// <param name="addClassModel"></param>
        /// <returns></returns>
        public int AddClass(AddClassViewModel addClassModel)
        {
            var classData = Mapper.Map<AddClassViewModel, AddClass>(addClassModel);

            _AddClassRepository.Add(classData);
            _unitOfWork.Commit();
            return 1;
        }

        /// <summary>
        /// Delete Class By Identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteClass(long id)
        {
            var studentDetails = _ProfileClassRepository.FindBy(m => m.Id == id && m.IsDeleted == false).FirstOrDefault();
            if (studentDetails != null)
                studentDetails.IsDeleted = true;
            _unitOfWork.Commit();
            return 1;
        }
    }
}
