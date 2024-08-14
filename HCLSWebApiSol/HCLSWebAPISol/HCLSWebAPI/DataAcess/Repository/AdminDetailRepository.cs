using HCLSWebAPI.DataAcess.IRepository;
using HCLSWebAPI.HCLSContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore.Internal;

using Microsoft.EntityFrameworkCore;


namespace HCLSWebAPI.DataAcess.Repository
{
    public class AdminDetailRepository : IAdminDetailRepository
    {
        public HCLSContextPro AdmDetailDb;

        public AdminDetailRepository(HCLSContextPro _AdmDetailDb)
        {
            AdmDetailDb = _AdmDetailDb;

        }
        public async Task<AdminDetail> AdminByAdminEmail(string Email, string Password)
        {
            return await AdmDetailDb.AdminDetails.Where(x => x.Email == Email && x.Password == Password).SingleOrDefaultAsync();
        }
        public async Task<int> AdminRegistration(AdminDetail AdmD)
        {
            await AdmDetailDb.AdminDetails.AddAsync(AdmD);
            return await AdmDetailDb.SaveChangesAsync();
        }

        public async Task<List<AdminDetail>> AllOperationalAdmins()
        {
            return await AdmDetailDb.AdminDetails.ToListAsync();
        }
        public async Task<int> DeleteAdmin(int AdminId)
        {
            var Adm = AdmDetailDb.AdminDetails.Find(AdminId);
            AdmDetailDb.AdminDetails.Remove(Adm);
            return await AdmDetailDb.SaveChangesAsync();
        }

        public async Task<int> UpdateAdmin(AdminDetail AdmD)
        {
            AdmDetailDb.AdminDetails.Update(AdmD);
            return await AdmDetailDb.SaveChangesAsync();
        }
    }
}
