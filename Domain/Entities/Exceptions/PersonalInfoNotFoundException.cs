using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class PersonalInfoNotFoundException : NotFoundException
    {
        public PersonalInfoNotFoundException(Guid languageId) : base($"The PersonalInfo with id:{languageId} not exists in database")
        {

        }
    }
}
