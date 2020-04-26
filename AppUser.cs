using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Group_9.DAL
{
    public class AppUser : IdentityUser
    {
        //Identity creates several of the important fields for you
        //TODO: Put any additional fields that you need for your user here (You don't need this for HW4)
        //First name is provided as an example
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }
    }
}