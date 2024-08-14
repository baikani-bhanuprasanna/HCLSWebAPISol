using HCLSWebAPI.DataAcess.IRepository;
using HCLSWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HCLSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminWebAPIController : ControllerBase
    {

        public IAdminRepository IAdmRef;
        public AdminWebAPIController(IAdminRepository _IAdmRef)
        {
            IAdmRef = _IAdmRef;

        }

        [HttpPost]
        [Route("AdminRegistrations")]
        public async Task<IActionResult> AdminRegistrations([FromBody] Admin Adm)
        {
            try
            {
                var count = await IAdmRef.AdminRegistrations(Adm);

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
                var ListAdm = await IAdmRef.AllOperationalAdmins();

                if (ListAdm.Count > 0)
                {
                    return Ok(ListAdm);
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

        [HttpPut]
        [Route("UpdateAdmin")]
        public async Task<IActionResult> UpdateAdmin([FromBody] Admin Adm)
        {
            try
            {
                var count = await IAdmRef.UpdateAdmin(Adm);

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
        [Route("DeleteAdm")]
        public async Task<IActionResult> DeleteAdm(int AdminTypeId)
        {
            try
            {
                var count = await IAdmRef.DeleteAdm(AdminTypeId);

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
