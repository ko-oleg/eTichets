using System;
using System.Collections.Generic;
using System.Linq;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService < AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        }
                        ,
                        new Cinema()
                        {
                            Name = "Cinema3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        }
                        ,
                        new Cinema()
                        {
                            Name = "Cinema4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        }
                        ,
                        new Cinema()
                        {
                            Name = "Cinema5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        }
                    });

                    context.SaveChanges();

                }
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Lari jame",
                            Bio = "This is BIO of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                            
                        },
                        new Actor()
                        {
                            FullName = "Black Black",
                            Bio = "This is BIO of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                            
                        },new Actor()
                        {
                            FullName = "Jacky Chan",
                            Bio = "This is BIO of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                            
                        },new Actor()
                        {
                            FullName = "Jack Ma",
                            Bio = "This is BIO of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                            
                        },new Actor()
                        {
                            FullName = "Loli Pop",
                            Bio = "This is BIO of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                            
                        },
                    });

                    context.SaveChanges();
                }
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is BIO of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Producer/Producer-1.jpeg"
                            
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is BIO of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Producer/Producer-2.jpeg"
                            
                        },new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is BIO of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Producer/Producer-3.jpeg"
                            
                        },new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is BIO of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Producer/Producer-4.jpeg"
                            
                        },new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is BIO of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Producer/Producer-5.jpeg"
                            
                        },
                    });

                    context.SaveChanges();
                }
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new()
                        {
                            Name = "Cold Soles",
                            Description = "his is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                }
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new()
                        {
                            ActorId = 2,
                            MovieId = 1
                        },
                    });
                }
            
            }
        }
    }
}