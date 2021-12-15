using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Enums;
using System;
using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.Seeding
{
    public static class DefaultObjects
    {
        public static List<Book> BooksObjects { get; set; } = new()
        {
            new Book
            {
                Id = 1,
                Title = "How Beautiful We Were",
                Genre = BookGenres.Novel,
                Language = "EN",
                Author = "Imbolo Mbue"
            },
            new Book
            {
                Id = 2,
                Title = "Intimacies",
                Genre = BookGenres.Novel,
                Language = "EN",
                Author = "Katie Kitamura"
            },
            new Book
            {
                Id = 3,
                Title = "The Dark Hours",
                Genre = BookGenres.Detective,
                Language = "EN",
                Author = "Michael Connelly"
            }
        };
        public static List<Film> FilmsObjects { get; set; } = new()
        {
            new Film
            {
                Id = 1,
                Title = "The Godfather",
                Genre = FilmGenres.Drama,
                Country = "USA",
                Year = new DateTime(1972),
                Language = "EN",
                VideoUrl = "google.com"
            },
            new Film
            {
                Id = 2,
                Title = "The Shawshank Redemption",
                Genre = FilmGenres.Drama,
                Country = "USA",
                Year = new DateTime(1994),
                Language = "EN",
                VideoUrl = "www.facebook.com"
            },
            new Film
            {
                Id = 3,
                Title = "The Dark Knight",
                Genre = FilmGenres.Action,
                Country = "USA",
                Year = new DateTime(2008),
                Language = "EN",
                VideoUrl = "www.twitter.com"
            }
        };
        public static List<Music> MusicObjects { get; set; } = new()
        {
            new Music
            {
                Id = 1,
                Title = "A Jolly Christmas from Frank Sinatra",
                Executor = "Frank Sinatra",
                Genre = MusicGenres.Jazz,
                Language = "EN"
            }
        };
        public static List<ComputerGame> ComputerGamesObjects { get; set; } = new()
        {
            new ComputerGame
            {
                Id = 1,
                Company = "CDProjectRed",
                Title = "The Witcher 3: Wild Hunt",
                Genre = ComputerGameGenres.ActionRolePlaying,
                Language = "RU",
                Review = "93/100"
            },
            new ComputerGame
            {
                Id = 2,
                Company = "Rockstar",
                Title = "Red Dead Redemption 2",
                Genre = ComputerGameGenres.ActionAdventure,
                Language = "EN",
                Review = "97/100"
            }
        };
        public static List<Genre> GenresObjects { get; set; } = new()
        {
            new Genre
            {
                Id = 1,
                Title = "ActionRolePlaying"
            },
            new Genre
            {
                Id = 2,
                Title = "ActionAdventure"
            },
            new Genre
            {
                Id = 3,
                Title = "Action"
            },
            new Genre
            {
                Id = 4,
                Title = "Fantasy"
            },
            new Genre
            {
                Id = 5,
                Title = "Jazz"
            }
        };
        public static List<Question> QuestionsObjects { get; set; } = new()
        {
            new Question
            {
                Id = 1,
                Formulation = "How are you? Your mood?",
                ImageUrl = "dasddsa@fsfdss"
            },
            new Question
            {
                Id = 2,
                Formulation = "What is your emotion now?",
                ImageUrl = "dasddsa@fsfdss"
            },
            new Question
            {
                Id = 3,
                Formulation = "How do you feel now?",
                ImageUrl = "dasddsa@fsfdss"
            }
        };
        public static List<Variant> VariantsObjects { get; set; } = new()
        {
            new Variant
            {
                Id = 1,
                Formulation = "Happiness"
            },
            new Variant
            {
                Id = 2,
                Formulation = "Boredom"
            },
            new Variant
            {
                Id = 3,
                Formulation = "Certainty"
            },
            new Variant
            {
                Id = 4,
                Formulation = "Compassion"
            },
            new Variant
            {
                Id = 5,
                Formulation = "Disappointment"
            },
            new Variant
            {
                Id = 6,
                Formulation = "Embarrassment"
            }
        };
        public static List<Test> TestsObjects { get; set; } = new()
        {
            new Test
            {
                Id = 1,
                Title = "Check you emotions"
            }
        };
    }
}
