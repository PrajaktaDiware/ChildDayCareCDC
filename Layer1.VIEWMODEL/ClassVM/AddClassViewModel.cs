using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.VIEWMODEL.ClassVM
{
    public class AddClassViewModel
    {
        public long Id { get; set; }
        public string ClassName { get; set; }
        public string Category { get; set; }
        public bool Status { get; set; }
        public int EnrollCapacity { get; set; }
        public string Session { get; set; }
        public string Room { get; set; }
        public bool? Mon { get; set; }
        public bool? Tue { get; set; }
        public bool? Wed { get; set; }
        public bool? Thu { get; set; }
        public bool? Fri { get; set; }
        public bool? Sat { get; set; }
        public string Gender { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public DateTime AgeCutOffDate { get; set; }
        public DateTime RegistrationStartDate { get; set; }
        public DateTime ClassStartDate { get; set; }
        public DateTime ClassEndDate { get; set; }
        public string StartTime { get; set;}
        public string EndTime { get; set; }
        public string Description { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
