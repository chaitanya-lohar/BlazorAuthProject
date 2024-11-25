﻿using FinalProject.Data;

namespace FinalProject.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public Task<Category> CreateAsync(Category category);
        public Task<Category> UpdateAsync(Category category);
        public Task<bool> DeleteAsync(int Id);
        public Task<Category> GetCategoryAsync(int Id);
        public Task<IEnumerable<Category>> GetAllCategoriesAsync();
    }
}