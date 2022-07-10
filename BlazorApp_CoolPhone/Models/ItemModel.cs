using System;

namespace BlazorApp_CoolPhone.Models
{
    public class ItemModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreateDate { get; set; }

        public bool Editable { get; set; } = false;
    }
}
