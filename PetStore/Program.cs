using PetStore.Data;
using System;

namespace PetStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            using var db = new PetStoreDbContext();

            db.Database.EnsureCreated();
        }
    }
}
