using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            //context.Database.Migrate();
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User()
                    {
                        FirstName = "Евгений",
                        LastName = "Громыко",
                        PassportNum = "AB1234567",
                        PersonalID = "1234567H123PB1",
                        PhoneNumber = "+375291460986",
                        Email = "egrom2002@gmail.com",
                        Password = "11111"
                    },
                    new User()
                    {
                        FirstName = "Ананас",
                        LastName = "Попуас",
                        PassportNum = "AB2345678",
                        PersonalID = "1234567H123PB2",
                        PhoneNumber = "80291460986",
                        Email = "1@gmail.com",
                        Password = "22222"
                    }
                    );
                context.SaveChanges();
            }

            if (!context.Banks.Any())
            {
                context.Banks.AddRange(
                    new Bank("BelarusBank", "AKBBBY2X"),
                    new Bank("BelAgroPromBank", "BAPBBY2X"),
                    new Bank("BPS-SberBank", "BPSBBY2X")
                    );
                context.SaveChanges();
            }
        }


    }
}
