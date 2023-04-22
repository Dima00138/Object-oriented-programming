using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork
{
    public class Route
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string Departure_Point { get; set; }
        public string Arrival_Point { get; set; }
        public virtual Shedule Shedule { get; set; }
        public string SheduleId { get; set; }
        public ICollection<Shedule> Shedules { get; set; }
        public Route (string arrivalPoint, string departurePoint, string id, Shedule sh)
        {
            Arrival_Point = arrivalPoint;
            Departure_Point = departurePoint;
            SheduleId = id;
            Shedule = sh;
            Shedules = new List<Shedule>();
            Shedules.Add(Shedule);
        }

        public Route(string arrivalPoint, string departurePoint)
        {
            Arrival_Point = arrivalPoint;
            Departure_Point = departurePoint;
            Shedules = new List<Shedule>();
        }
    }
}
