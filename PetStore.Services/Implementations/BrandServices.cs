﻿using PetStore.Data;
using PetStore.Data.Models;
using PetStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStore.Services.Implementations
{
    public class BrandServices : IBrandServices
    {
        private PetStoreDbContext dbContext;

        public BrandServices(PetStoreDbContext data)
            => this.dbContext = data;

        public int Create(string name)
        {

            if (name == null)
            {
                throw new InvalidOperationException($"Brand name cannot be null!");
            }


            if (name.Length > DataValidation.NameMaxLength)
            {
                throw new InvalidOperationException($"Brand name cannot be more than {name.Length} symbols");
            }

            Brand brand = new Brand
            {
                Name = name
            };

            this.dbContext.Brands.Add(brand);
            this.dbContext.SaveChanges();
            return brand.Id;


        }



        internal Brand GetByName(string name)
          => this.dbContext
                     .Brands
                        .FirstOrDefault(x => x.Name.ToLower() == name.ToLower());


        public IEnumerable<BrandListingServiceModel> SearchByName(string name)
        {
            return this.dbContext.Brands
                       .Where(x => x.Name.ToLower().Contains(name.ToLower()))
                       .Select(x => new BrandListingServiceModel
                       {
                           Id = x.Id,
                           Name = name
                       })
                       .ToList();
        }

        public bool Exists(int brandId)
             => this.dbContext.Brands.Any(x => x.Id == brandId);

        public BrandsWithToysService FindByIdWithToys(int id)
          => this.dbContext
                         .Brands
                         .Where(br => br.Id == id)
                         .Select(br => new BrandsWithToysService
                         {
                             Name = br.Name,
                             Toys = br.Toys
                          .Select(t => new ToyListingServiceModel
                          {
                              Id = t.Id,
                              Name = t.Name,
                              Price = t.Price,
                              TotalOrders = t.ToyOrders.Count
                          }).ToList()
                         })
            .FirstOrDefault();

    }
}
