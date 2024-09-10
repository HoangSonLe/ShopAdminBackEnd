﻿using API.Models.APIModels.Auth;
using Application.Base;
using Application.Services.TokenServices;
using Application.Services.WebInterfaces;
using Core.CommonModels.BaseModels;
using Core.Helper;
using Core.Models.ViewModels.AccountViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;

namespace API.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthController : BaseController<AuthController>
    {
        private readonly ITokenService _tokenService;
        public AuthController(
            ILogger<AuthController> logger,
            IUserService userService,
            ITokenService tokenService
            ) : base(logger, userService)
        {
            _tokenService = tokenService;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("GetToken")]
        public async Task<Acknowledgement<TokenModel>> GetToken([FromBody] LoginViewModel request)
        {
            var ack = new Acknowledgement<TokenModel>();
            try
            {
                if (string.IsNullOrEmpty(request.UserName) || string.IsNullOrEmpty(request.Password))
                    throw new Exception(string.Format("Tên đăng nhập và mật khẩu không được để trống!"));

                var userAck = await UserService.Login(request);
                if (userAck.IsSuccess == false)
                {
                    ack.ErrorMessageList = userAck.ErrorMessageList;
                    return ack;
                }

                var user = userAck.Data;
                var token = _tokenService.GenerateJwtToken(user.Id.ToString());
                ack.StatusCode = HttpStatusCode.OK;
                ack.Data = new TokenModel()
                {
                    UserId = user.Id,
                    Name = user.Name,
                    RoleIds = user.RoleIdList,
                    AccessToken = token.JwtToken,
                    RefreshToken = _tokenService.GenerateRefreshToken(),
                    ExpiredDate = token.Expires,
                };
                var saveAck = await UserService.UpdateRefreshToken(ack.Data.UserId,ack.Data.RefreshToken);
                return ack;
            }
            catch (Exception ex)
            {
                ack.ExtractMessage(ex);
                return ack;
            }
        }
        [HttpPost]
        [Route("Logout")]
        public async Task<Acknowledgement> Logout(LogoutModel request)
        {
            DateTime dtRecieve = DateTime.Now;
            var ack = new Acknowledgement();
            try
            {
                ack.StatusCode = HttpStatusCode.OK;
                return ack;
            }
            catch (Exception ex)
            {
                Logger.LogError("Logout: " + ex.Message);
                ack.ExtractMessage(ex);
                return ack;
            }
        }
      

    }
}
