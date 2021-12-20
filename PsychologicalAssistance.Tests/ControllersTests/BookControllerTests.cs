using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Data.Helpers.AutoMapper;
using PsychologicalAssistance.Services.Implementation;
using PsychologicalAssistance.Services.Interfaces;
using PsychologicalAssistance.Tests.Common;
using PsychologicalAssistance.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PsychologicalAssistance.Tests.ControllersTests
{
    public class BookControllerTests
    {
        private readonly Mock<IBookService> _bookService;
        private readonly IMapper _mapper;

        public BookControllerTests()
        {
            _bookService = BasicClassForMocking.CreateServiceMock<IBookService, Book>();
            _mapper = BasicClassForMocking.ConfigMapper(new BookProfile());
        }

        [Fact]
        public async Task GetAllBooks_ReturnsOkObjectResult_WithListOfBookDtosValue()
        {
            //arrange
            _bookService.Setup(x => x.GetAllBooksAsync()).ReturnsAsync(() => new List<BookDto>());
            var controller = new BookController(_bookService.Object, _mapper);

            //act
            var result = await controller.GetAllBooks() as OkObjectResult;

            //assert
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<List<BookDto>>(result.Value);
        }

        [Fact]
        public async Task GetAllBooks_ReturnsNotFoundResult_StatusCode404()
        {
            //arrange
            _bookService.Setup(x => x.GetAllBooksAsync()).ReturnsAsync(() => null);
            var controller = new BookController(_bookService.Object, _mapper);

            //act
            var result = await controller.GetAllBooks() as NotFoundResult;

            //assert
            Assert.NotNull(result);
            Assert.IsType<NotFoundResult>(result);
            Assert.Equal(404, result.StatusCode);
        }

        [Fact]
        public async Task GetBookById_ReturnsOkObjectResult_WithBookDtoValue()
        {
            //arrange
            _bookService.Setup(x => x.GetBookByIdAsync(1)).ReturnsAsync(() => new BookDto());
            var controller = new BookController(_bookService.Object, _mapper);

            //act
            var result = await controller.GetBookById(1) as OkObjectResult;

            //assert
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<BookDto>(result.Value);
        }

        [Fact]
        public async Task GetBookById_ReturnsNotFoundResult_StatusCode404()
        {
            //arrange
            _bookService.Setup(x => x.GetBookByIdAsync(1)).ReturnsAsync(() => null);
            var controller = new BookController(_bookService.Object, _mapper);

            //act
            var result = await controller.GetBookById(1) as NotFoundResult;

            //assert
            Assert.NotNull(result);
            Assert.IsType<NotFoundResult>(result);
            Assert.Equal(404, result.StatusCode);
        }
    }
}
