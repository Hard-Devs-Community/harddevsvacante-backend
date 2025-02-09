using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HardDevsVacantes.BusinessLayers.Dtos;
using HardDevsVacantes.BusinessLayers.Interfaces;
using HardDevsVacantes.Controllers.Base;
using HardDevsVacantes.DataModel.Context;
using HardDevsVacantes.DataModel.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace HardDevsVacantes.API.Controllers
//{
//    [Authorize(Policy = "RequireAdministratorRole")]
//    public class UsuarioController : BaseController<Usuario, UsuarioDto>
//    {
//        IUsuarioService _service;
//        MainDbContext _context;

//        public UsuarioController(IUsuarioService service, IMapper mapper)
//            : base(service, mapper)
//        {
//            _service = service;
//        }


//    }
//}

