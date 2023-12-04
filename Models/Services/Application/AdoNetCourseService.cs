using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DotNet1.Models.Services.infrastructure;
using DotNet1.Models.ViewModels;

namespace DotNet1.Models.Services.Application
{
    public class AdoNetCourseService : ICourseService
    {
        private readonly IDatabaseAccessor db;

        public AdoNetCourseService(IDatabaseAccessor db)
        {
            this.db = db;
        }
        public CourseDetailViewModel GetCourse(int id)
        {
            throw new NotImplementedException();
        }

        public List<CourseService> GetCourses()
        {
            string query = "SELECT *FROM Courses";
            DataSet dataSet = db.Query(query);
            throw new NotImplementedException();
        }
    }
}