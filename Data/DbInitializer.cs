using Herbet_Ioana_Claudia_Lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace Herbet_Ioana_Claudia_Lab2.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new
           LibraryContext(serviceProvider.GetRequiredService
            <DbContextOptions<LibraryContext>>()))
            {
                if (context.Books.Any())
                {
                    return; // BD a fost creata anterior
                }
                context.Books.AddRange(
                new Book
                {
                    Title = "Baltagul",
                    Price=Decimal.Parse("22")},
               
                new Book
                {
                    Title = "Enigma Otiliei",
                    Price=Decimal.Parse("18")},
               
                new Book
                {
                    Title = "Maytrei",
                    Price=Decimal.Parse("27")}
               
                );


                context.Clients.AddRange(
                new Client
                {
                    Name = "Popescu Marcela",
                    Adress = "Str. Plopilor, nr. 24",
                    BirthDate = DateTime.Parse("1979-09-01")
                },
                new Client
                {
                    Name = "Mihailescu Cornel",
                    Adress = "Str. Bucuresti, nr. 45, ap. 2",BirthDate=DateTime.Parse("1969 - 07 - 08")}
               
                );

                context.Authors.AddRange(
                new Author
                {
                    FirstName = "Mihail",
                    LastName = "Sadoveanu",
                },

                new Author
                {
                    FirstName = "George",
                    LastName = "Călinescu",
                },

                new Author
                {
                    FirstName = "Mircea",
                    LastName = "Eliade",
                }

                );

                context.SaveChanges();
            }
        }

    }
}
