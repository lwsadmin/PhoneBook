using Abp.Authorization;
using PhoneBook.Authorization.Roles;
using PhoneBook.Authorization.Users;

namespace PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
