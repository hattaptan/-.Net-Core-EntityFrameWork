using Ent.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent.DataModel
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int ClaMaxClassSize { get; set; }
        public Language ClassLanguage { get; set; }

    }
}
