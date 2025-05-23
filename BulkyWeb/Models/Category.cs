﻿
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BulkyWeb.Models

{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

   
        [DisplayName("Display Order")]
        [Range(1, 100)]
        public int DisplayOrder {  get; set; }
    }
}
