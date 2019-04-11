using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnBoardingTask.Models
{
    public class Sales
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date{ get; set; }


        [Display(Name = "Customer Name")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
