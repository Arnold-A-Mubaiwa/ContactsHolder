using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ContactsHolder.Models{
    public static class SeedData{
        public static void Initialize(IServiceProvider serviceProvider){
            using (var context = new ContactContext(serviceProvider.GetRequiredService<DbContextOptions<ContactContext>>()))
            {
                if(context.Contact.Any()){
                    return ;
                }

                context.Contact.AddRange(
                     new Contact
                    {
                        Name = "Arnold",
                        Surname = "Mubaiwa",
                        contactNumber = "0642681132",
                        email = "arnoldmubaiwa99@gmail.com",
                        type = "Personal",
                        Importance = "Yes"
                        
                    },

                    new Contact
                    {
                        Name = "Hillary ",
                        Surname = "Dzika",
                        contactNumber = "0215894471",
                        email = "hillarydzika@gmail.com",
                        type = "Personal",
                        Importance = "Yes"
                    },

                    new Contact
                    {
                        Name = "Samual 2",
                        Surname = "Zagabe",
                        contactNumber = "0718894561",
                        email = "samuelzagabe@gmail.com",
                        type = "Personal",
                        Importance = "Yes"
                    },

                    new Contact
                    {
                        Name = "Shelly",
                        Surname = "Mavhunika",
                        contactNumber = "0754461234",
                        email = "shellymavhunika@gmail.com",
                        type = "Personal",
                        Importance = "Yes"
                    }
                );
                context.SaveChanges();
                }

            }
        }
    }
