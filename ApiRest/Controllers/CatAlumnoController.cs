using ApiRest.DataAccess;
using ApiRest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatAlumnoController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public CatAlumnoController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<catalumnos> GET()
        {
            return _dataAccessProvider.GetCatAlumnoRecords();

        }

        [HttpGet("{id}")]
        public catalumnos details(int id)
        {
            return _dataAccessProvider.GetCatAlumnoSingleRecord(id);
        }
        [HttpPost]
        public IActionResult Create([FromBody] catalumnos alumno)
        {
            if (ModelState.IsValid)
            {
                Guid obj = Guid.NewGuid();
                //alumno.id = obj.ToString();
                _dataAccessProvider.AddAlumnoRecord(alumno);
                return Ok();
            }
            return BadRequest();
        }

    }
}
