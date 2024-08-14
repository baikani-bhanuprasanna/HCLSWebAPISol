using HCLSWebAPI.DataAcess.IRepository;
using HCLSWebAPI.Models;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HCLSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminDetailWebAPIController : ControllerBase
    {
        public IAdminDetailRepository IAdmDRef;

        public AdminDetailWebAPIController(IAdminDetailRepository _IAdmDRef)
        {
            IAdmDRef = _IAdmDRef;
        }

        [HttpPost]
        [Route("AdminRegistration")]
        public async Task<IActionResult> AdminRegistration([FromBody] AdminDetail AdmD)
        {
            try
            {
                    var count = await IAdmDRef.AdminRegistration(AdmD);

                    if (count > 0)
                    {
                        return Ok(count);
                    }
                    else
                    {
                        return BadRequest("Record Not Inserted");
                    }
                
            }
            catch (Exception ex)
            {
                return BadRequest("Something Went Wrong....!\n" + "Issue  :" + ex.Message + ".\n We will slove this issue soon");
            }
        }

        [HttpGet]
        [Route("AllOperationalAdmins")]
        public async Task<IActionResult> AllOperationalAdmins()
        {
            try
            {
                var ListAdmD = await IAdmDRef.AllOperationalAdmins();

                if (ListAdmD.Count > 0)
                {
                    return Ok(ListAdmD);
                }
                else
                {
                    return NotFound("Records Are Not Available in the Database");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Something Went Wrong....!\n" + "Issue  :" + ex.Message + ".\n We will slove this issue soon");
            }
        }

        [HttpGet]
        [Route("AdminByAdminEmail")]
        public async Task<IActionResult> AdminByAdminEmail(string Email, string Password)
        {
            try
            {
                var AdmD = await IAdmDRef.AdminByAdminEmail(Email, Password);

                if (AdmD != null)
                {

                    return Ok(AdmD);

                }
                else
                {

                    return NotFound("Record Is Not Available in the Database with ");

                }

            }
            catch (Exception ex)
            {

                return BadRequest("Something Went Wrong....!\n" + "Issue  :" + ex.Message + ".\n We will slove this issue soon");

            }

        }

        [HttpPut]
        [Route("UpdateAdmin")]
        public async Task<IActionResult> UpdateAdmin([FromBody] AdminDetail AdmD)
        {
            try
            {
                var count = await IAdmDRef.UpdateAdmin(AdmD);

                if (count > 0)
                {

                    return Ok(count);

                }
                else
                {

                    return BadRequest("Record Is Not Updated");

                }

            }
            catch (Exception ex)
            {

                return BadRequest("Something Went Wrong....!\n" + "Issue  :" + ex.Message + ".\n We will slove this issue soon");

            }

        }
        [HttpDelete]
        [Route("DeleteAdmin")]
        public async Task<IActionResult> DeleteAdmin(int AdminId)
        {
            try
            {
                var count = await IAdmDRef.DeleteAdmin(AdminId);

                if (count > 0)
                {

                    return Ok(count);

                }
                else
                {

                    return BadRequest("Record Is Not Deleted");

                }

            }
            catch (Exception ex)
            {

                return BadRequest("Something Went Wrong....!\n" + "Issue  :" + ex.Message + ".\n We will slove this issue soon");

            }

        }

    }
}
