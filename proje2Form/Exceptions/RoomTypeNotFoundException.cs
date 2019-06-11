using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Exceptions
{
    class RoomTypeNotFoundException:Exception
    {
        public RoomTypeNotFoundException(string roomname)
            : base(String.Format("Geçersiz Oda İsmi: {0}", roomname))
        {
            ExceptionLogger.LogAnExcaption(this);
        }
    }
}
