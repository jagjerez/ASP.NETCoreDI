
using ServicioDTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicioDTO.DTO_S
{
    public class Usuario: IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {

        public Usuario() : this(Guid.NewGuid())
        {

        }

        public Usuario(Guid guid)
        {
            _guid = guid;
        }

        public int id { get; set; }
        
        public string name { get; set; }

        Guid _guid;

        public Guid UserId => _guid;
    }
}
