using Application.Services.Login;
using Application.Services.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Facade
{
    public interface IFacadeServicecs
    {
        public ILoginService LoginService { get; }
        public IRegisterService RegisterService { get; }
    }

    public class FacadeService : IFacadeServicecs
    {
        private ILoginService _loginService;
        public ILoginService LoginService
        {
            get=> _loginService = _loginService ?? new LoginService();
            
        }


        private IRegisterService _registerService;
        public IRegisterService RegisterService
        {
            get=> _registerService = _registerService ?? new RegisterService();           
        }

    }
}
