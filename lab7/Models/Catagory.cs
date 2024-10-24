using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
