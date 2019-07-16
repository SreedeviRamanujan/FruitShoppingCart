namespace FruitCart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CartDetail
    {
        [Key]
        public int CardId { get; set; }

        public int? UserId { get; set; }

        public virtual UserDetail UserDetail { get; set; }
    }
}
