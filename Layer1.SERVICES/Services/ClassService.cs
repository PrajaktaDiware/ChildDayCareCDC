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
    /// Display all the data of Class
    /// </summary>
    /// <value>
    /// Get all the data 
    /// </value>
    /// <returns></returns>
    public class ClassService : IClassService
    {
        private readonly IEntityBaseRepository<ProfileClass> _ProfileClassRepository;
        private readonly IEntityBaseRepository<AddClass> _AddClassRepository;
        private readonly IUnitOfWork _unitOfWork;

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
        public List<ProfileClassViewModel> GetAllClassWithoutParam()
        {
            var studentdata = _ProfileClassRepository.GetAll().ToList();
            var studentModelData = Mapper.Map<List<ProfileClass>, List<ProfileClassViewModel>>(studentdata);
            return studentModelData;
        }
        public int AddClass(AddClassViewModel addClassModel)
        {
            //throw new NotImplementedException();
            var classData = Mapper.Map<AddClassViewModel, AddClass>(addClassModel);

            _AddClassRepository.Add(classData);
            _unitOfWork.Commit();

            return 1;

        }

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
