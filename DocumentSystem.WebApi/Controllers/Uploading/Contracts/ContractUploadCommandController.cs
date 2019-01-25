using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentSystem.WebApi.Resources.Uploading;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocumentSystem.WebApi.Controllers.Uploading.Contracts
{
    [Produces("application/json")]
    [Route("api/uploading")]
    public class ContractUploadCommandController : ControllerBase
    {
        [HttpPost("contractUploads")]
        public IActionResult CreateContract([FromBody] ContractUploadRequest contractUpload)
        {
            try
            {
                return new OkResult();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}