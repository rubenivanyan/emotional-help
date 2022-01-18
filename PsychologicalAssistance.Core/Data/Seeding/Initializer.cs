﻿using System;
using System.Linq;

namespace PsychologicalAssistance.Core.Data.Seeding
{
    public static class Initializer
    {
        public static void Initialize(ApplicationDbContext dbContext)
        {
            var type = typeof(IDbInitializers);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract);
            Type[] parametersTypes = { typeof(ApplicationDbContext) };
            object[] arguments = { dbContext };

            foreach(var item in types)
            {
                var method = item.GetMethod("Initialize", parametersTypes);
                IDbInitializers complexDbInitializers = (IDbInitializers)Activator.CreateInstance(item);
                method.Invoke(complexDbInitializers, arguments);
            }
        }
    }
}
