using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPIDemo.Model.MySQL
{
    [Table("student")]
    public class Student
    {
        [Column("id")]
        public int ID { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("sex")]
        public byte Sex { get; set; }

        [Column("age")]
        public int Age { get; set; }
    }
}
