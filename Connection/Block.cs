using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Connection
{
    public class Block
    {
        public string BlockTime { get; set; }
        public string BlockBgSound { get; set; }

        public virtual bool IsPlay()
        {
            if (BlockTime == DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"))
            {
                return true;
            }
            return false;
        }

    }
}
