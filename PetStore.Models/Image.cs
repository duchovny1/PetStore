namespace PetStore.Data.Models
{
    using System.Collections.Generic;
    public class Image
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Pet> Pets { get; set; } = new HashSet<Pet>();
    }
}
