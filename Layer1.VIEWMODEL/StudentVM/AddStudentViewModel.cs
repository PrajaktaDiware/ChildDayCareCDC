using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.VIEWMODEL.StudentVM
{
    public class AddStudentViewModel
    {
        //Child Info
        public long Id { get; set; }
        public string ChildFirstName { get; set; }
        public string ChildLastName { get; set; }
        public string ChildGender { get; set; }
        public DateTime? DOB { get; set; }

        //ParentInfo
        public string ParentFatherName { get; set; }
        public string ParentMotherName { get; set; }
        public string ParentMobile { get; set; }
        public string ParentEmailId { get; set; }

        //Guardian Info
        public string GuardianFirstName { get; set; }
        public string GuardianLastName { get; set; }
        public string GuardianRelation { get; set; }
        public string GuardianMobile { get; set; }
        public string GuardianEmailId { get; set; }

        //Contact Information
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }

        //Enrollment Details
        public string Enrolledclass { get; set; }
        public string EnrolledRoom { get; set; }
        public DateTime? EnrolledStartDate { get; set; }
        public DateTime? EnrolledEndDate { get; set; }

        //Additional 
        public string AdditionalDetails { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
