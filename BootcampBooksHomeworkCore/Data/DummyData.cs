using BootcampBooksHomeworkCore.Data;
using BootcampBooksHomeworkDTO.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampBooksHomeworkCore.Data
{
    public static class DummyData
    {
        public static void Dummy(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<BookContext>();
            context.Database.Migrate();
            var categories = new List<Category>()
            {
                new Category{Name="Bilim Kurgu", Movies=new List<Book>()
                {
                    new Book {Name="Cesur Yeni Dünya",Writer = "Aldous Huxley",ImageUrl="1.jpg"},
                    new Book {Name="Zaman Makinesi",Writer = "H.G. Wells",ImageUrl="2.jpg"},
                    new Book {Name="Kurtuluş Projesi",Writer = "Andy Weir",ImageUrl="3.jpg"}
                }
                },
                new Category {Name="Edebiya"},
                new Category {Name="Roman"},
                new Category {Name="Felsefe"}
            };
            var books = new List<Book>()
            {
                new Book{Name="Süt Lekesi",Writer="Esra Ezmeci",ImageUrl="4.jpg",Categories= new List<Category>(){ categories[1],categories[3] } },
                new Book{Name="Körlük",Writer="Jose Saramago",ImageUrl="5.jpg",Categories= new List<Category>(){ categories[1],categories[2] } },
                new Book{Name="Beyaz Zambaklar Ülkesinde",Writer="Grigory Petrov",ImageUrl="6.jpg",Categories= new List<Category>(){ categories[2] } },
                new Book{Name="Kozmos",Writer="Carl Sagan",ImageUrl="7.jpg",Categories= new List<Category>(){ categories[1],categories[3] } },
                new Book{Name="Incognito - Beynin Gizli Hayatı",Writer="David Eagleman",ImageUrl="8.jpg",Categories= new List<Category>(){ categories[3] } },
                new Book{Name="Benim Gözümden Dünya",Writer="Albert Einstein",ImageUrl="9.jpg",Categories= new List<Category>(){ categories[1] } },
                new Book{Name="Ne İçin Varsan Onun İçin Yaşa - Bir Arayışın Romanı",Writer="Hikmet Anıl Öztekin",ImageUrl="10.jpg",Categories= new List<Category>(){ categories[1],categories[3] } },
                new Book{Name="Kalk Yerine Yat",Writer="Şermin Yaşar",ImageUrl="11.jpg",Categories= new List<Category>(){ categories[1],categories[3] } },
                new Book{Name="Simyacı",Writer="Paulo Coelho",ImageUrl="12.jpg",Categories= new List<Category>(){ categories[1],categories[2] } },
                new Book{Name="Altıncı Koğuş",Writer="Anton Pavloviç Çehov",ImageUrl="13.jpg",Categories= new List<Category>(){ categories[2],categories[3] } }
            };
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Books.Count() == 0)
                {
                    context.Books.AddRange(books);
                }
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(categories);
                }
                context.SaveChanges();
            }
        }
    }
}
