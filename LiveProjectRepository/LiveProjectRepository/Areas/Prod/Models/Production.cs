using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheatreCMS3.Areas.Prod.Models
{
    public class Production
    {
        public int ProductionID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Playwright { get; set; }
        public int Runtime { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OpeningDay { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ClosingDay { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime ShowTimeEve { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime ShowTimeMat { get; set; }
        public int Season { get; set; }
        public bool IsWorldPremier { get; set; }
        public string TicketLink { get; set; }

        public virtual List<CastMember> CastMembers { get; set; }
        public virtual ProductionPhoto DefaultPhoto { get; set; }
        public virtual List<ProductionPhoto> ProductionPhotos { get; set; }
        public virtual List<CalendarEvent> CalendarEvents { get; set; }
    }
}