using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.Dto
{
    public class DtoPathServices
    {

        public string Path { get; private set; }

        public DtoPathServices(string path)
        {
            this.Path = path;
        }
    }
}
