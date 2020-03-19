﻿using AAAA.Aplication.Interfaces;
using AAAA.Aplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AAAA.UI.Web.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _userAppService;
        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpGet]
        public string SignIn()
        {
            return _userAppService.SignIn(new UserViewModel
            {
                Account = "111",
                Password = "222"
            });
        }
    }
}