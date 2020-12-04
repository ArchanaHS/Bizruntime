using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmploymentProject
{
    class EmployeeDetails
    {
        
            [key]
            public int EmpId { get; set; }

            [Column(TypeName = "nvarchar(50)")]
            public string EmpName { get; set; }

            [Column(TypeName = "nvarchar(50)")]
            public string ComanyName { get; set; }

            [Column(TypeName = "nvarchar(50)")]
            public int ComanyId { get; set; }

            [Column(TypeName = "nvarchar(50)")]
            public string Designation { get; set; }

            [Column(TypeName = "nvarchar(50)")]
            public string Department { get; set; }

        
       
    }
}
