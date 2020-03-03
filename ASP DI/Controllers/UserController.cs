using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_DI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicioDTO.Interfaces;

namespace ASP_DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UsuarioService _operationService;
        private readonly IOperationTransient _transientOperation;
        private readonly IOperationScoped _scopedOperation;
        private readonly IOperationSingleton _singletonOperation;
        private readonly IOperationSingletonInstance _singletonInstanceOperation;

        public UserController(UsuarioService operationService,
            IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation,
            IOperationSingletonInstance singletonInstanceOperation)
        {
            _operationService = operationService;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
            _singletonInstanceOperation = singletonInstanceOperation;
        }



        // GET: api/User
        [HttpGet]
        public IEnumerable<string[]> Get()
        {
            return new string[][] {
                    new string[]{_transientOperation.UserId.ToString() , _scopedOperation.UserId.ToString() ,_singletonOperation.UserId.ToString() , _singletonInstanceOperation.UserId.ToString()  },
                    new string[]{ _operationService.TransientOperation.UserId.ToString() , _operationService.ScopedOperation.UserId.ToString() , _operationService.SingletonOperation.UserId.ToString() , _operationService.SingletonInstanceOperation.UserId.ToString()  }
                };
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
