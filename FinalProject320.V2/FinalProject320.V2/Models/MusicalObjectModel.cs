using System.ComponentModel.DataAnnotations;
using FinalProject320.V2.Controllers;
using FinalProject320.V2.Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject320.V2.Models
{
    public class MusicalObjectModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the item name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the item description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the per-item value")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter the item category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter the item quantity")]
        public int ProductCount { get; set; }

    }
    public class MusicInstrumentsDBContext : DbContext
    {
        public DbSet<MusicalObjectModel> MusicalObjectModels { get; set; }
    }
}
