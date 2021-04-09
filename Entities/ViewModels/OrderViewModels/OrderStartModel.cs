using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.ViewModels.OrderViewModels
{
    class OrderStartModel
    {
        public string Titel { get; set; }

        public string Description { get; set; }

        public DateTime OrderCreation { get; set; }

        public DateTime OrderTime { get; set; }

        public string Price { get; set; }

        public string MoreDetails { get; set; }
    }
}
