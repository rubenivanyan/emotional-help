using AutoMapper;
using System.Collections.Generic;

namespace PsychologicalAssistance.Core.Data.Helpers.AutoMapper
{
    public static class MapCollections
    {
        public static IEnumerable<OutputType> MapCollection<InputType, OutputType>(IEnumerable<InputType> inputCollection, IMapper mapper)
        {
            var outputCollection = new List<OutputType>();
            foreach (var item in inputCollection)
            {
                outputCollection.Add(mapper.Map<InputType, OutputType>(item));
            }

            return outputCollection;
        }
    }
}
