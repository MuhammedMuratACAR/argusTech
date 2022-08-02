using argusTech.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace argusTech.Entities.Concrete
{
    public class User : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
