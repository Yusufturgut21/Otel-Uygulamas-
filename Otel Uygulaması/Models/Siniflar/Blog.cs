using Otel_Uygulaması.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Otel_Uygulaması.Models
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public String Aciklama { get; set; }
        
        public String BlogImage { get; set;}
    
       public ICollection<Yorumlar> Yorumlars { get; set; }
    
    
    }
}