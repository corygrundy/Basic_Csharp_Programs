using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TheatreCMS3.Areas.Prod.Models
{
    [Table("ProductionPhotos")]
    public class ProductionPhoto
    {
        [Key]
        public int ProPhotoId { get; set; }
        public Byte[] PhotoFile { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int? PhotosProduction { get; set; }
        public Production Production { get; set; }
    }
}