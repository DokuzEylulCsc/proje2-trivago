﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Exceptions
{
    class HotelTypeNotFoundException:Exception
    {
        public HotelTypeNotFoundException(string hotelname)
            : base(String.Format("Geçersiz Otel İsmi: {0}", hotelname))
        {
            StreamWriter stream = File.AppendText("Log.txt");
            stream.WriteLine(base.Message);
            stream.Flush();
            stream.Close();
        }
    }
}
