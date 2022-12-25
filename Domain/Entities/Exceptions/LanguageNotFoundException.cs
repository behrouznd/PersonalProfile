using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class LanguageNotFoundException : NotFoundException
    {
        public LanguageNotFoundException(Guid languageId) : base($"The language with id:{languageId} does not exist in Database")
        {
        }
    }
}
