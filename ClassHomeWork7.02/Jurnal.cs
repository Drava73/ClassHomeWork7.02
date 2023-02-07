using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomeWork7._02
{
    public class Jurnal
    {
        private string namejur;
        private string webaddrs;
        private string about;
        private string ipweb;
        public Jurnal()
        {
            namejur = "Null";
            webaddrs = "Null";
            about = "Null";
            ipweb = "Null";
        }
        public Jurnal(string nameweb, string webaddrs, string about, string ipweb)
        {
            this.namejur = nameweb;
            this.webaddrs = webaddrs;
            this.about = about;
            this.ipweb = ipweb;

        }
        public string WebSite
        {
            get { return namejur; }
            set { namejur = value; }
        }
        public string WebAddres
        {
            get { return webaddrs; }
            set { webaddrs = value; }
        }
        public string AboutSite
        {
            get { return about; }
            set { about = value; }
        }
        public string IP
        {
            get { return ipweb; }
            set { ipweb = value; }
        }
        public void Input()
        {
            Console.WriteLine("Input Name:");
            namejur = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input Address:");
            webaddrs = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input about site:");
            about = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input IP:");
            ipweb = Convert.ToString(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Name:{namejur}\nAddress:{webaddrs}\nAbout site::{about}\nIP:{ipweb}";
        }
    }
}
