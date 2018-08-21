using System.Collections.Generic;
using PhoneBook.Roles.Dto;
using PhoneBook.Users.Dto;

namespace PhoneBook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
