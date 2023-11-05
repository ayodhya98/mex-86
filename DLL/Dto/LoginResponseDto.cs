using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Dto
{
    public class LoginResponseDto
    {
        public string Id { get; set; }
        public string Email { get; set; }

        public string Jwt { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
