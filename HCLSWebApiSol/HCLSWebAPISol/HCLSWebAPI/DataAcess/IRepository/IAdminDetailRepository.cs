using HCLSWebAPI.Models;

namespace HCLSWebAPI.DataAcess.IRepository
{
    public interface IAdminDetailRepository
    {

        Task<List<AdminDetail>> AllOperationalAdmins();

        Task<AdminDetail> AdminByAdminEmail(string Email, string Password);

        Task<int> AdminRegistration(AdminDetail AdmD);

        Task<int> UpdateAdmin(AdminDetail AdmD);

        Task<int> DeleteAdmin(int AdminId);


    }
}
