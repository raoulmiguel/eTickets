using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //ADD Cinema
                if (!context.Cinemas.Any())
                {

                   context.Cinemas.AddRange(new List<Cinema>(){

                        new Cinema()
                        {

                            Name = "cinema 1",
                            Logo = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg",
                            Description = "Description du film"
                        },
                        new Cinema()
                        {

                            Name = "cinema 2",
                            Logo = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg",
                            Description = "Description du film"
                        },
                        new Cinema()
                        {

                            Name = "cinema 3",
                            Logo = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg",
                            Description = "Description du film"
                        },
                        new Cinema()
                        {

                            Name = "cinema 4",
                            Logo = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg",
                            Description = "Description du film"
                        },
                        new Cinema()
                        {

                            Name = "cinema 5",
                            Logo = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg",
                            Description = "Description du film"
                        },
                    });
                   context.SaveChanges();

                }
            
                //ADD Actors
                if(!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>(){

                        new Actor()
                        {

                            FullName = "Actor 1",
                            Bio = "votre biographie",
                            ProfilePictureURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg"
                        },
                        new Actor()
                        {

                            FullName = "Actor 2",
                            Bio = "votre biographie",
                            ProfilePictureURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg"
                        },
                        new Actor()
                        {

                            FullName = "Actor 3",
                            Bio = "votre biographie",
                            ProfilePictureURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg"
                        },
                        new Actor()
                        {

                            FullName = "Actor 4",
                            Bio = "votre biographie",
                            ProfilePictureURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg"
                        },
                        new Actor()
                        {

                            FullName = "Actor 5",
                            Bio = "votre biographie",
                            ProfilePictureURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg"
                        },
                    });
                    context.SaveChanges();
                }
                //ADD Producers
                
                if(!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>(){

                        new Producer()
                        {

                            FullName = "Producer 1",
                            Bio = "votre biographie",
                            ProfilePictureURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg"
                        },
                        new Producer()
                        {

                            FullName = "Producer 2",
                            Bio = "votre biographie",
                            ProfilePictureURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg"
                        },
                        new Producer()
                        {

                            FullName = "Producer 3",
                            Bio = "votre biographie",
                            ProfilePictureURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg"
                        },
                       new Producer()
                        {

                            FullName = "Producer 4",
                            Bio = "votre biographie",
                            ProfilePictureURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg"
                        },
                        new Producer()
                        {

                            FullName = "Producer 5",
                            Bio = "votre biographie",
                            ProfilePictureURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg"
                        },
                    });
                    context.SaveChanges();
                }
                //ADD Movies
                if(!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "DBZ",
                            Description = "votre description",
                            Price = "30.99",
                            ImageURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 1,
                            ProducerID = 5,
                            MovieCategory = MovieCategory.Cartoon

                        },
                        new Movie()
                        {
                            Name = "PURE",
                            Description = "votre description",
                            Price = "39.50",
                            ImageURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 3,
                            ProducerID = 4,
                            MovieCategory = MovieCategory.Drama

                        },
                        new Movie()
                        {
                            Name = "planète sauvage",
                            Description = "votre description",
                            Price = "39.50",
                            ImageURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 4,
                            ProducerID = 4,
                            MovieCategory = MovieCategory.Documentary

                        },
                        new Movie()
                        {
                            Name = "24H",
                            Description = "votre description",
                            Price = "39.50",
                            ImageURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 2,
                            ProducerID = 3,
                            MovieCategory = MovieCategory.Action

                        },
                        new Movie()
                        {
                            Name = "Jamel comedy",
                            Description = "votre description",
                            Price = "39.50",
                            ImageURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 5,
                            ProducerID = 2,
                            MovieCategory = MovieCategory.Comedy

                        },
                        new Movie()
                        {
                            Name = "Dracula",
                            Description = "votre description",
                            Price = "39.50",
                            ImageURL = "https://www.kanpai.fr/sites/default/files/uploads/2010/11/dragon-ball-kai-boo.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 2,
                            ProducerID = 1,
                            MovieCategory = MovieCategory.Horror

                        },

                    });
                    context.SaveChanges();
                }
                //ADD Actors_Movies
                if(!context.Actors_Movies.Any())
                {
                  context.Actors_Movies.AddRange(new List<Actor_Movie>()
                  {
                     new Actor_Movie()
                     {
                         ActorID = 1,
                         MovieId = 3
                     },
                     new Actor_Movie()
                     {
                         ActorID = 3,
                         MovieId = 1
                     },
                     new Actor_Movie()
                     {
                         ActorID = 4,
                         MovieId = 2
                     },
                     new Actor_Movie()
                     {
                         ActorID = 4,
                         MovieId = 4
                     },
                  });
                  context.SaveChanges();
                }

            }
        }
    }
}