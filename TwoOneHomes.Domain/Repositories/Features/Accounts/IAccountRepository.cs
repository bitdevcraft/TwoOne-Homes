
namespace TwoOneHomes.Domain.Repositories.Features.Accounts;

public interface IAccountRepository
{
    Task GetEmployees();
    Task GetProperties();
    Task GetProjects();

}