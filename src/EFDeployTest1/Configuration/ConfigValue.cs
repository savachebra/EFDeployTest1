using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFDeployTest1.Configuration
{
    public class ConfigValue
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
