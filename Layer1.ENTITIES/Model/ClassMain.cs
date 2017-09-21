using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.ENTITIES.Model
{
    public class ClassMain: IEntityBase
    {
        public long Id { get; set; }
        public string Class { get; set; }
        public string Session { get; set; }
        public string RegistrationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Category { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }

    }
}
