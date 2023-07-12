using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokDesignerPro_2.Models
{
    public enum Level 
    {
        Star,
        Vip
    }
    public class UserInfo
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public Level Level{ get; set; }
    }
}
