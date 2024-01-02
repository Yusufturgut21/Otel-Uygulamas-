using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Otel_Uygulaması.Models.Siniflar
{
    public class AdresBlog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public String Aciklama { get; set; }

        public string AdresAcik { get; set; }

        public string Mail { get; set; }

        public string Telefon { get; set; }

        public string Konum { get; set; }

    }
}