using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork
{
    [Serializable]
    public class Shedule
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string id { get; set; }
        //public string? Trains { get; protected set; }
        //public string? Platform { get; protected set; }
        //public string? FromPlace { get; protected set; }
        //public string? ToPlace { get; protected set; }
        //public string? TypeShedule { get; set; }

        //public Shedule(string Trains, string Platform, string FromPlace, string ToPlace, string TypeShedule = "Type 1")
        //        {
        //            id = Guid.NewGuid().ToString();
        //            this.Trains = Trains;
        //            this.Platform= Platform;
        //            this.FromPlace = FromPlace;
        //            this.ToPlace = ToPlace;
        //            this.TypeShedule = TypeShedule;
        //        }

        // ---------    NEW     -------------- 

        public string Id_Train {get; set;}
        public DateTime Date { get; set;}
        public short Time_In_Way { get; set;}
        public short Frequency { get; set;}
        public virtual Route Route { get; set;}
        public int RouteId { get; set;}
        //public virtual ICollection<Shedule> Shedules { get; set;}

        public Shedule(string id, string idTrain, DateTime date, string departurePoint, string arrivalPoint, short timeInWay, short frequency)
        {
            this.id = id;
            Id_Train = idTrain;
            Date = date;
            Time_In_Way = timeInWay;
            Frequency = frequency;
            Route r = new Route(arrivalPoint, departurePoint, id, this);
            RouteId = r.id;
        }

        public Shedule(string id, string idTrain, DateTime date, int routeId, short timeInWay, short frequency)
        {
            this.id = id;
            Id_Train = idTrain;
            Date = date;
            this.RouteId = routeId;
            Time_In_Way = timeInWay;
            Frequency = frequency;
        }

        public Shedule(string id, string idTrain, DateTime date, Route route, short timeInWay, short frequency)
        {
            this.id = id;
            Id_Train = idTrain;
            Date = date;
            this.Route = route;
            Time_In_Way = timeInWay;
            Frequency = frequency;

            RouteId = route.id;
            Route.SheduleId = id;
            Route.Shedule = this;
            Route.Shedules.Add(this);
        }

        public string this[string index]
        {
            get
            {
                switch (index) {
                    case "id": return id;
                    case "Id_Train": return Id_Train;
                    case "Date": return Date.ToString();
                    case "route": return Route.id.ToString();
                    case "Time_In_Way": return Time_In_Way.ToString();
                    case "Frequency": return Frequency.ToString();
                    default: return null;
                } 
            }
            set
            {
                switch (index)
                {
                    case "id": id = value; break;
                    case "Id_Train": Id_Train = value; break;
                    case "Date": Date = Convert.ToDateTime(value); break;
                    case "route": RouteId = Convert.ToInt32(value); break;
                    case "Time_In_Way": Time_In_Way = Convert.ToInt16(value); break;
                    case "Frequency": Frequency = Convert.ToInt16(value); break;
                    default: break;
                }
            }
        }

    }
}
