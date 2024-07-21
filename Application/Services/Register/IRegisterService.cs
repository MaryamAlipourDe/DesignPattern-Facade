using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Register
{
    public interface IRegisterService
    {
        public void Execute();

    }

    public class RegisterService : IRegisterService
    {
        public void Execute()
        {
            Action1();
        }
        private void Action1()
        {

        }
    }
}
