using System.Threading.Tasks;
using PhoneBook.Configuration.Dto;

namespace PhoneBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
