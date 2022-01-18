﻿using AutoMapper;
using PsychologicalAssistance.Core.Data;
using PsychologicalAssistance.Core.Data.DTOs;
using PsychologicalAssistance.Core.Data.Entities;
using PsychologicalAssistance.Core.Repositories.Abstract;
using PsychologicalAssistance.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsychologicalAssistance.Core.Repositories.Implementation
{
    public class VariantRepository : DataRepository<Variant>, IVariantRepository
    {
        private readonly IMapper _mapper;

        public VariantRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<VariantDto>> GetAllVariantsDtoAsync()
        {
            var variants = await GetAllItemsAsync();
            if (variants == null)
            {
                return null;
            }

            var variantsDto = _mapper.Map<IEnumerable<Variant>, IEnumerable<VariantDto>>(variants);
            return variantsDto;
        }

        public async Task<VariantDto> GetVariantDtoAsync(int id)
        {
            var variant = await GetItemByIdAsync(id);
            if (variant == null)
            {
                return null;
            }

            var variantDto = _mapper.Map<Variant, VariantDto>(variant);
            return variantDto;
        }

        public async Task<List<string>> GetGenresTitlesByVariantTitleAsync(string formulation)
        {
            var genres = await Task.Run(() => DbSet
                .Where(variant => variant.Formulation.Equals(formulation))
                .Select(variant => variant.Genres.ToList()).FirstOrDefault());
            var genresTitles = genres.Select(genre => genre.Title).ToList();
            return genresTitles;
        }

        public async Task<List<VariantGenresDto>> GetAllVariantsWithGenresDtoAsync()
        {
            var variants = await Task.Run(() => DbSet.Select(variant => new VariantGenresDto
            {
                Id = variant.Id,
                Formulation = variant.Formulation,
                Genres = _mapper.Map<IEnumerable<Genre>, IEnumerable<GenreDto>>(variant.Genres).ToList()
            }).ToList());

            return variants;
        }

        public async Task<VariantGenresDto> GetVariantWithGenresByIdDtoAsync(int id)
        {
            var variantDto = await Task.Run(() => DbSet.Where(variant => variant.Id == id).Select(variant => new VariantGenresDto
            {
                Id = variant.Id,
                Formulation = variant.Formulation,
                Genres = _mapper.Map<IEnumerable<Genre>, IEnumerable<GenreDto>>(variant.Genres).ToList()
            }).FirstOrDefault());

            return variantDto;
        }
    }
}
