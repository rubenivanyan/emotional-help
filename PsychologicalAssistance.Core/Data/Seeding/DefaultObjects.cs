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
                Title = "How Beautiful We Were",
                Genre = BookGenres.Novel,
                Language = "EN",
                Author = "Imbolo Mbue"
            },
            new Book
            {
                Title = "Intimacies",
                Genre = BookGenres.Novel,
                Language = "EN",
                Author = "Katie Kitamura"
            },
            new Book
            {
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
                Title = "The Godfather",
                Genre = FilmGenres.Drama,
                Country = "USA",
                Year = new DateTime(1972),
                Language = "EN",
                VideoUrl = "google.com"
            },
            new Film
            {
                Title = "The Shawshank Redemption",
                Genre = FilmGenres.Drama,
                Country = "USA",
                Year = new DateTime(1994),
                Language = "EN",
                VideoUrl = "www.facebook.com"
            },
            new Film
            {
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
                Company = "CDProjectRed",
                Title = "The Witcher 3: Wild Hunt",
                Genre = ComputerGameGenres.ActionRolePlaying,
                Language = "RU",
                Review = "93/100"
            },
            new ComputerGame
            {
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
                Title = "ActionRolePlaying"
            },
            new Genre
            {
                Title = "ActionAdventure"
            },
            new Genre
            {
                Title = "Action"
            },
            new Genre
            {
                Title = "Fantasy"
            },
            new Genre
            {
                Title = "Jazz"
            }
        };
        public static List<Question> QuestionsObjects { get; set; } = new()
        {
            new Question
            {
                Formulation = "How are you? Your mood?",
                ImageUrl = "dasddsa@fsfdss"
            },
            new Question
            {
                Formulation = "What is your emotion now?",
                ImageUrl = "dasddsa@fsfdss"
            },
            new Question
            {
                Formulation = "How do you feel now?",
                ImageUrl = "dasddsa@fsfdss"
            }
        };
        public static List<Variant> VariantsObjects { get; set; } = new()
        {
            new Variant
            {
                Formulation = "Happiness"
            },
            new Variant
            {
                Formulation = "Boredom"
            },
            new Variant
            {
                Formulation = "Certainty"
            },
            new Variant
            {
                Formulation = "Compassion"
            },
            new Variant
            {
                Formulation = "Disappointment"
            },
            new Variant
            {
                Formulation = "Embarrassment"
            }
        };
        public static List<Test> TestsObjects { get; set; } = new()
        {
            new Test
            {
                Title = "Check you emotions"
            }
        };
    }
}
