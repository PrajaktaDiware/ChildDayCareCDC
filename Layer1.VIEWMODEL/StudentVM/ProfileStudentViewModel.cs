using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.VIEWMODEL.StudentVM
{
  public  class ProfileStudentViewModel
    {
        public long Id { get; set; }
        public string ChildFirstName { get; set; }
        public string ChildLastName { get; set; }
        public string ChildGender { get; set; }
        public DateTime? DOB { get; set; }
        
        //Enrollment Details
        public string Enrolledclass { get; set; }
        public string EnrolledRoom { get; set; }
        public DateTime? EnrolledStartDate { get; set; }
        public DateTime? EnrolledEndDate { get; set; }

        //Additional
        public bool? IsDeleted { get; set; }
    }






    //Prajakta

    //public class ProfileStudentViewModel
    //{
    //    public long Id { get; set; }
    //    public string Name { get; set; }
    //    public string Class { get; set; }
    //    public string Room { get; set; }
    //    public string Gender { get; set; }
    //    public DateTime DOB { get; set; }
    //    public DateTime StartDate { get; set; }
    //    public DateTime EndDate { get; set; }
    //    public bool Status { get; set; }
    //    public bool? IsDeleted { get; set; }
    //}


}
