using System;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CompanyEmployees.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public WeatherForecastController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        //private readonly ILoggerManager _logger;
        //public WeatherForecastController(ILoggerManager logger)
        //{
        //    _logger = logger;
        //}
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //_repository.Company.GetAllCompanies(true);
            //_repository.Employee.AnyMethodFromEmployeeRepository();
            //_logger.LogInfo("Here is info message from the controller.");
            //_logger.LogDebug("Here is debug message from the controller.");
            //_logger.LogWarn("Here is warn message from the controller.");
            //_logger.LogError("Here is error message from the controller.");
            return new string[] { "value1", "value2" };
        }
    }
}
