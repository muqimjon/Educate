using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Educate.Domain.Commons;

namespace Educate.Domain.Entities
{
    public class Attachment:Auditable
    {
        public string Filepath { get; set; }
        public string Filename { get; set; }

    }
}
