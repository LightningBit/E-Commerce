﻿// LightningBits
using System;
using SharedServices.Data;
using SharedServices;

namespace SharedServices.Respository.IRespository
{
    public interface ICategoryRespository
    {
        public CategoryDTO Create(CategoryDTO objDTO);

        public CategoryDTO Update(CategoryDTO objDTO);

        public int Delete(int id);

        public CategoryDTO Get(int id);

        public IEnumerable<CategoryDTO> GetAll();

    }
}

