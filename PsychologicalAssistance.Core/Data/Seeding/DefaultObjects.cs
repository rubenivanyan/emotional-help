using Microsoft.AspNetCore.Identity;
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
            },
            new Book
            {
                Title = "The Lord Of The Rings",
                Genre = BookGenres.Adventure,
                Language = "EN",
                Author = "J.R.R. Tolkien"
            },
            new Book
            {
                Title = "Harry Potter",
                Genre = BookGenres.Fantasy,
                Language = "EN",
                Author = "J.K. Rowling"
            },
            new Book
            {
                Title = "A Study In Scarlet",
                Genre = BookGenres.Detective,
                Language = "EN",
                Author = "Arthur Conan Doyle"
            },
            new Book
            {
                Title = "Digital Fortress",
                Genre = BookGenres.TechnoThriller,
                Language = "EN",
                Author = "Dan Brown"
            },
            new Book
            {
                Title = "Origin",
                Genre = BookGenres.Thriller,
                Language = "EN",
                Author = "Dan Brown"
            },
            new Book
            {
                Title = "The Hobbit, or There and Back Again",
                Genre = BookGenres.JuvenileFantasy,
                Language = "EN",
                Author = "J.R.R. Tolkien"
            },
            new Book
            {
                Title = "King Solomon's Mines",
                Genre = BookGenres.LostWorld,
                Language = "EN",
                Author = "H. Rider Haggard"
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
            },
            new Music
            {
                Title = "Piano Concerto No. 24",
                Executor = "Wolfgang Amadeus Mozart",
                Genre = MusicGenres.Classical,
                Language = ""
            },
            new Music
            {
                Title = "Triple Concerto",
                Executor = "Ludwig van Beethoven",
                Genre = MusicGenres.Classical,
                Language = ""
            },
            new Music
            { 
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
                Title = "Detective"
            },
            new Genre
            {
                Title = "Fantasy"
            },
            new Genre
            {
                Title = "Horror"
            },
            new Genre
            {
                Title = "ScienceFiction"
            },
            new Genre
            {
                Title = "Poetry"
            },
            new Genre
            {
                Title = "Novel"
            },
            new Genre
            {
                Title = "Adventure"
            },
            new Genre
            {
                Title = "TechnoThriller"
            },
            new Genre
            {
                Title = "Thriller"
            },
            new Genre
            {
                Title = "JuvenileFantasy"
            },
            new Genre
            {
                Title = "LostWorld"
            },
            new Genre
            {
                Title = "Shooter"
            },
            new Genre
            {
                Title = "Survival"
            },
            new Genre
            {
                Title = "Puzzle"
            },
            new Genre
            {
                Title = "ActionAdventure"
            },
            new Genre
            {
                Title = "ActionRolePlaying"
            },
            new Genre
            {
                Title = "Comedy"
            },
            new Genre
            {
                Title = "Drama"
            },
            new Genre
            {
                Title = "Action"
            },
            new Genre
            {
                Title = "Rock"
            },
            new Genre
            {
                Title = "Jazz"
            },
            new Genre
            {
                Title = "Classical"
            },
            new Genre
            {
                Title = "Pop"
            },
            new Genre
            {
                Title = "Electronic"
            },
            new Genre
            {
                Title = "Folk"
            }
        };
        public static List<Question> QuestionsObjects { get; set; } = new()
        {
            new Question
            {
                Formulation = "How are you? Your mood?",
                QuestionGroup = QuestionGroups.Asthenia,
                ImageUrl = "dasddsa@fsfdss"
            },
            new Question
            {
                Formulation = "What is your emotion now?",
                QuestionGroup = QuestionGroups.SocialAnxiety,
                ImageUrl = "dasddsa@fsfdss"
            },
            new Question
            {
                Formulation = "How do you feel now?",
                QuestionGroup = QuestionGroups.Depression,
                ImageUrl = "dasddsa@fsfdss"
            }
        };
        public static List<Variant> VariantsObjects { get; set; } = new()
        {
            new Variant
            {
                Formulation = "Happiness",
                Value = 4
            },
            new Variant
            {
                Formulation = "Boredom",
                Value = 3
            },
            new Variant
            {
                Formulation = "Certainty",
                Value = 2
            },
            new Variant
            {
                Formulation = "Compassion",
                Value = 1
            },
            new Variant
            {
                Formulation = "Disappointment",
                Value = 0
            },
            new Variant
            {
                Formulation = "Embarrassment",
                Value = 1
            }
        };
        public static List<Test> TestsObjects { get; set; } = new()
        {
            new Test
            {
                Title = "Check you emotions"
            }
        };
        public static List<Training> TrainingsObjects { get; set; } = new()
        {
            new Training
            {
                Title = "Time management: effective time management tools",
                Description = "The training is designed for a wide range of listeners and is recommended for anyone who wants to increase personal efficiency.",
                StartDate = new DateTime(20 / 12 / 2021)
            },
            new Training
            {
                Title = "Emotional intelligence. Emotion control and management",
                Description = "The training will be useful for everyone who communicates with clients, partners and visitors of the company; who works in conditions of emotional pressure, who needs to be able to regulate their own emotional state in the course of complex communications.",
                StartDate = new DateTime(21 / 12 / 2021)
            },
            new Training
            {
                Title = "Conflictology: conflict situations and conflict personalities. Ways to manage conflicts",
                Description = "The training is designed for a wide range of listeners and is recommended to all those who face conflict situations and want to learn how to manage them.",
                StartDate = new DateTime(22 / 12 / 2021)
            },
            new Training
            {
                Title = "How to get rid of resentment and learn to forgive",
                Description = "Why are we offended? This question is not easy to answer. To do this, you need to see yourself from the side. By causing another person to feel guilty, we involuntarily and unconsciously increase our self-esteem. A person with a decent self-esteem does not feel the need to blame another, because he is so good! Feelings of resentment and dissatisfaction often go hand in hand. We invite you to understand these intricacies and get closer to the feeling of inner harmony in our personal group.",
                StartDate = new DateTime(23 / 12 / 2021)
            },
            new Training
            {
                Title = "Psychological counseling for adolescents and young people",
                Description = "The training seminar is designed for school psychologists, counseling psychologists, career guidance and counseling specialists, social workers and educators engaged in counseling work with adolescents and young people, as well as senior students studying psychological and pedagogical specialties.",
                StartDate = new DateTime(18 / 12 / 2021)
            },
            new Training
            {
                Title = "Mistakes in relationships",
                Description = "Each of us wants his relationships with people, especially with one and only loved one, to bring joy and pleasure, not stress, but wings. But have you seen many people who are completely satisfied with their relationship (unless, of course, they have already passed the stage of love, when the charm of novelty and hope for a better future illuminate everything around with pink light)? According to my observations, people who know how to build a harmonious relationship with their other half are a happy exception to the rule. But we can improve our relationships with our loved ones if we stop making mistakes in relationships that poison and destroy them.",
                StartDate = new DateTime(19 / 12 / 2021)
            }
        };
        public static List<IdentityRole> IdentityRoles { get; set; } = new()
        {
            new IdentityRole
            {
                Name = "Client",
                NormalizedName = "CLIENT"
            },
            new IdentityRole
            {
                Name = "Mentor",
                NormalizedName = "MENTOR"
            },
            new IdentityRole
            {
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            }
        };
    }
}
