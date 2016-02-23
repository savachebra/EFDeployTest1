using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using EFDeployTest1.Configuration;

namespace EFDeployTest1.Models
{
    public static class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            InitializeApplicationDbContext(serviceProvider);
            InitializeConfigurationDbContext(serviceProvider);
        }

        private static void InitializeApplicationDbContext(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.Author.Any())
            {
                context.Author.AddRange(
                    new Author
                    {
                        FirstName = "Erich Maria",
                        LastName = "Remarque",
                        Country = "Germany",
                        Books = new[]
                        {
                            new Book
                            {
                                ISBN = "123456",
                                Title = "Three friends"
                            },
                            new Book
                            {
                                ISBN = "992288",
                                Title = "Black obelisk"
                            }

                        }
                    },
                    new Author
                    {
                        FirstName = "Hemingway",
                        Country = "US",
                        Books = new[]
                        {
                            new Book
                            {
                                ISBN = "9999",
                                Title = "Who bells ring for"
                            }
                        }
                    }

                );

                context.SaveChanges();
            }
        }


        private static void InitializeConfigurationDbContext(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ConfigurationDbContext>();
            context.Database.Migrate();

            if (!context.ConfigValues.Any())
            {
                context.ConfigValues.AddRange(
                    new ConfigValue
                    {
                        Key = "ObjectId",
                        Value = "12354"
                    },
                    new ConfigValue
                    {
                        Key = "Color",
                        Value = "Red"
                    }
                );

                context.SaveChanges();
            }
        }

    }
}
