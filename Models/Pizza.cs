using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public string Image { get; set; }

        public float Price { get; set; }

        public Pizza()
        {

        }

        public Pizza(int id, string title, string description, string image, float price)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
            Price = price;
        }
    }
}
