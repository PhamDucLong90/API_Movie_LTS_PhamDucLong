using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

namespace Project_XemPhim.entity
{
    public class Movie
    {
        /*Id integer [primary key]
  MovieDuration integer
  EndTime datetime
  PremiereDate datetime
  Description varchar
  Director varchar
  Image varchar
  HeroImage varchar
  Language varchar
  MovieTypeId integer
  Name varchar
  RateId integer
  Trailer varchar
  IsActive bit*/
        [Key]
        public int Id_Moive { get; set; }
        public int MovieDuration { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime PremiereDate { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string Image {  get; set; }
        public string HeroImage {  get; set; }
        public string Language {  get; set; }
        public int MovieTypedId { get; set; }
        public string Name { get; set; }
        public int RateId { get; set; }
        public string Trailer {  get; set; }
        public bool IsActive {  get; set; }
        public IEnumerable<Schedule> schedules { get; set; }
        public Rate Rate { get; set; }
        public MovieType MovieType { get; set; }
    }
}
