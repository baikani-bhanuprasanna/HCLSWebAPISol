using HCLSWebAPI.Models;

namespace HCLSWebAPI.DataAcess.IRepository
{
    public interface IAdminRepository
    {

        Task<List<Admin>> AllOperationalAdmins();

        Task<int> AdminRegistrations(Admin Adm);

        Task<int> UpdateAdmin(Admin Adm);

        Task<int> DeleteAdm(int AdminTypeId);
    }
}
