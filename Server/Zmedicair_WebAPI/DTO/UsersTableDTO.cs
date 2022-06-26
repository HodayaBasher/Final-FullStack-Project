using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class UsersTableDTO
    {

        public short UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public DateTime UserDateOfBirth { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserStatus { get; set; }
        public string UserPassword { get; set; }
    }
}
