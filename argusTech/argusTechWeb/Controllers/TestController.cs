using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using argusTech.Business.Interfaces;
using argusTech.DTO.DTOs.UserDtos;
using argusTech.Entities.Concrete;
using argusTechWeb.CustomFiles;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace argusTechWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public TestController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;

        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {

            return Ok(_mapper.Map<List<UserListDto>>(await _userService.GetAllAsync()));
        }

        [HttpPost("[action]")]
        [ValidModel]
        public async Task<IActionResult> SaveUser(UserAddDto userAddDto)
        {
            await _userService.AddAsync(_mapper.Map<User>(userAddDto));
            return Created("", userAddDto);
        }

    }
}
