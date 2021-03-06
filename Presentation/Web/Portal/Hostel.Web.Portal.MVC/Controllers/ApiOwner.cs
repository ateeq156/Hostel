﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Hostel.Web.Portal.MVC.Controllers
{
    [Authorize("owner")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    [Route("owner")]
    [ValidateAntiForgeryToken]
    public class ApiOwner : ControllerBase
    {
    }
}
