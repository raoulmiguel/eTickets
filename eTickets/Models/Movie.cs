using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]

        public int ID { get; set; }


        public string Name { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        // Relationships :  Movie - Actor
        public List<Actor_Movie> Actors_Movies { get; set; }

        // Relationships : Cinema

        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]

        public Cinema Cinama { get; set; }

        // Relationships : Producer

        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]

        public Producer Producer { get; set; }
    }
}
