using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class parameterSingersInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public Uri thumb { get; set; }
        public string country { get; set; }

        public parameterSingersInfo(string Id, string Name, Uri Thumb, string Country)
        {
            this.id = Id;
            this.name = Name;
            this.thumb = Thumb;
            this.country = Country;
        }

        public parameterSingersInfo(string Id, string Name, string Country)
        {
            this.id = Id;
            this.name = Name;
            this.country = Country;
        }

        public parameterSingersInfo(string Id, string Name, Uri Thumb)
        {
            this.id = Id;
            this.name = Name;
            this.thumb = Thumb;
        }

        public parameterSingersInfo(string Id, string Name)
        {
            this.id = Id;
            this.name = Name;
        }

        public parameterSingersInfo()
        { }
    }
}
