using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.DATA.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private CStudentContext cStudentContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="dbFactory">The database factory.</param>
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        /// <summary>
        /// Gets the database context.
        /// </summary>
        /// <value>
        /// The database context.
        /// </value>
        private CStudentContext CStudentContext
        {
            get { return cStudentContext ?? (cStudentContext = dbFactory.Init()); }
        }

        /// <summary>
        /// Commits this instance.
        /// </summary>
        public void Commit()
        {
            CStudentContext.Commit();
        }
    }
}
