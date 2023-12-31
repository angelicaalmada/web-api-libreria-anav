﻿using Libreria_anav.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading;

namespace Libreria_anav.Data
{
    public class AppDbInitializer
    {
        //Metodo que agrega datos a nuestra BD
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Book.Any())
                {
                    context.Book.AddRange(new Book()
                    {
                        Titulo = "1st Book Title",
                        DEscripcion = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "Biography",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,


                    },
                    new Book()
                    {
                        Titulo = "2nd Book Title",
                        DEscripcion = "2nd Book Description",
                        IsRead = true,
                        Genero = "Biography",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,


                    });
                    context.SaveChanges();
                }
            }
        }


    }
}
