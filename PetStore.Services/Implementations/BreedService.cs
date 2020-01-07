﻿namespace PetStore.Services.Implementations
{
    using System;
    using System.Linq;
    using PetStore.Data;
    using PetStore.Data.Models;

    public class BreedService : IBreedService
    {
        private readonly PetStoreDbContext data;

        public BreedService(PetStoreDbContext data)
        {
            this.data = data;
        }
        public void Add(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace!");
            }

            var breed = new Breed()
            {
                Name = name
            };

            this.data.Breeds.Add(breed);
            this.data.SaveChanges();
        }

        public bool Exists(int breedId)
               => this.data.Breeds.Any(x => x.Id == breedId);
    }
}
