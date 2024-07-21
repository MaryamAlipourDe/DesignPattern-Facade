using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Login
{
    public interface ILoginService
    {
        public void Execute();
    }

    public class LoginService : ILoginService
    {
        public void Execute()
        {
            Action1();
            Action2();
            Action3();
           
        }
        private void Action1() { }
        private void Action2() { }
        private void Action3() { }
    }
}
