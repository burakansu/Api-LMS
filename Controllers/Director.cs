﻿using Business.Concrete;
using Data;
using DataAccess.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Director : ControllerBase
    {
        private IDirectorService Service;
        public Director()
        {
            Service = new DirectorManager();
        }

        [HttpGet("{id}")]
        public TBL_Directors GetDirector(int id)
        {
            return Service.GetDirector(id);
        }
    }
}