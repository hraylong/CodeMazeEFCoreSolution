using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeMazeEFCore.DataAccessLayer
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public bool IsRegularStudent { get; set; }
        public int LocalCalculation { get; set; }
    }
}
