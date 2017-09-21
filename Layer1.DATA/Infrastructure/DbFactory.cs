using Layer1.DATA.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.DATA.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private CStudentContext cStudentContext;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <returns></returns>
        public CStudentContext Init()
        {
            return cStudentContext ?? (cStudentContext = new CStudentContext());
        }

        protected override void DisposeCore()
        {
            cStudentContext?.Dispose();
        }
    }
}
