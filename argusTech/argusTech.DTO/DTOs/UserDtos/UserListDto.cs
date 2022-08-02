using argusTech.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace argusTech.DTO.DTOs.UserDtos
{
    public class UserListDto:IDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
