using Common.UserIdentityCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models.Orders
{
    public class Order : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Titel is required")]
        public string Titel { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        //აქ დეფაულტად უნდა ჩაემატოს
        [Required(ErrorMessage = "Time of Creation is required")]
        public DateTime OrderCreation { get; set; }

        public DateTime OrderTime { get; set; }

        public string Price { get; set; }

        public string MoreDetails { get; set; }
    }
}
