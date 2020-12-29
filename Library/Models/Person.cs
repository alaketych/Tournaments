using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
     class Person {

        public int Id { get; set; }

        [Display(Name = "Given Name")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        [StringLength(200, MinimumLength = 6)]
        [Required]
        public string EmailAddress { get; set; }


        [Display(Name = "Cellphone Number")]
        [StringLength(20, MinimumLength = 10)]
        [Required]
        public string CellphoneNumber { get; set; }

        public string FullName {
            get {
                return $"{ FirstName } { LastName }";
            }
        }

    }
}
