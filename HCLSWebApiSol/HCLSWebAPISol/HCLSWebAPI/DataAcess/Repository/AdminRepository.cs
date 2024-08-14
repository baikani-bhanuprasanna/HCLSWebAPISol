using HCLSWebAPI.DataAcess.IRepository;
using HCLSWebAPI.HCLSContext;
using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace HCLSWebAPI.DataAcess.Repository
{
    public class AdminRepository : IAdminRepository


    {
        public HCLSContextPro AdminDb;

        public AdminRepository(HCLSContextPro _AdminDb)
        {
            AdminDb = _AdminDb;

        }
        
        public async Task<int> AdminRegistrations(Admin Adm)
        {
          await  AdminDb.Admins.AddAsync(Adm);
            return await AdminDb.SaveChangesAsync();
         }

        public async Task<List<Admin>> AllOperationalAdmins()
        {
           return await AdminDb.Admins.ToListAsync();
        }

        public async Task<int> DeleteAdm(int AdminTypeId)
        {
            var adm = AdminDb.Admins.Find(AdminTypeId);

            AdminDb.Admins.Remove(adm);

            return await AdminDb.SaveChangesAsync();
        }
      
        public async Task<int> UpdateAdmin(Admin Adm)
        {
            AdminDb.Admins.Update(Adm);

            return await AdminDb.SaveChangesAsync();
        }
    }
}
