using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheatreCMS3.Areas.Prod.Models
{
    public enum PositionEnum { Actor, Director, Technician, StageManager, Other }

    public class CastMember
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> YearJoined { get; set; }
        public PositionEnum MainRole { get; set; }
        public string Bio { get; set; }
        public Byte[] Photo { get; set; }
        public bool CurrentMember { get; set; }
        public string Character { get; set; }
        public Nullable<int> CastYearLeft { get; set; }
        public Nullable<int> DebutYear { get; set; }

        public int? CastProduction { get; set; }
        public Production Production { get; set; }
        public ICollection<Production> Productions { get; set; }
    }
}