using AutoMapper;
using Layer1.ENTITIES;
using Layer1.ENTITIES.Model;
using Layer1.VIEWMODEL;
using Layer1.VIEWMODEL.ClassVM;
using Layer1.VIEWMODEL.StudentVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Layer1.WEB.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CStudent, CStudentViewModel>();
            CreateMap<CStudentViewModel, CStudent>();

            //Prajakta
            CreateMap<AddStudent, AddStudentViewModel>();
            CreateMap<AddStudentViewModel, AddStudent>();

            //Alpit
            CreateMap<AddStudent, ProfileStudentViewModel>();
            CreateMap<ProfileStudentViewModel, AddStudent>();

            CreateMap<ProfileClass, ProfileClassViewModel>();
            CreateMap<ProfileClassViewModel, ProfileClass>();

            CreateMap<AddClass, AddClassViewModel>();
            CreateMap<AddClassViewModel, AddClass>();
        }
    }
}