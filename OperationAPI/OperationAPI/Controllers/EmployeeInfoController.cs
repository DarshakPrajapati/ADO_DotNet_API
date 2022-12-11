using Microsoft.AspNetCore.Mvc;
using OperationDomian.Entities;
using OperationRepository.Repositories;

namespace OperationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeInfoController : Controller
    {
        EmployeeInfoRepository objemployee = new EmployeeInfoRepository();

        [HttpGet]
        [Route("Index")]
        public IEnumerable<EmployeeInfo> Index()
        {
            return objemployee.GetEntity();
        }

        [HttpPost]
        [Route("Create")]
        public int Create(EmployeeInfo employee)
        {
            return objemployee.AddEntity(employee);
        }

        [HttpPut]
        [Route("Edit")]
        public int Edit(EmployeeInfo employee)
        {
            return objemployee.UpdateEntity(employee);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public int Delete(int id)
        {
            return objemployee.DeleteEntity(id);
        }
    }
}
