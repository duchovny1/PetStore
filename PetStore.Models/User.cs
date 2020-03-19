using PetStore.Data.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetStore.Data.Models
{
    using static DataValidation;
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Telephone { get; set; }


        [Required]
        public virtual int RoleId 
        {
            get
            {
                return (int)this.Role;
            }
            set
            {
                Role = (UserRoles)value;
            }
        }

        [Required]
        public virtual UserRoles Role { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
