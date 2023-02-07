using RecruitmentManagementSystemModels.V1;

namespace AccountManagementService.V1.Interface
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAllAccounts();
        Account GetAccountById(Guid id);
        void CreateAccounts(Account account);
        void UpdateAccounts(Guid id, Account account);
        void DeleteAccount(Guid id);
    }
}
