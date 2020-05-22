﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MshopWorkShop.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Index]
        [Column("product_id")]
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "max length 150 charactors")]
        [Column("product_name")]
        [Display(Name = "Product name")]
        public string ProductName { get; set; }


        [Column("category_id")]
        [Display(Name = "Category name")]
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Column("path_img")]
        [Display(Name = "Product Image")]
        [MaxLength]
        public string PathImg { get; set; }
      
        [Column("unit_price")]
        [DefaultValue(0)]
        [Display(Name = "Price")]
        [Range(0, int.MaxValue, ErrorMessage = "The Quantity must be more than 0 or equal")]

        public decimal UnitPrice { get; set; } = 0;

        [Column("units_in_stock")]
        [DefaultValue(0)]
        [Display(Name = "Unit in Stock")]
        public int InStock { get; set; } = 0;

    }
}