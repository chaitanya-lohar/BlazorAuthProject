using FinalProject.Data;
using FinalProject.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace FinalProject.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext context;
        public CategoryRepository(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await context.Category.ToListAsync();
        }

        public async Task<Category> CreateAsync(Category category)
        {
            await context.Category.AddAsync(category);
            context.SaveChanges();
            return category;
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            var category = await context.Category.Where(x=>x.Id == Id).FirstOrDefaultAsync();
            if (category != null)
            {
                context.Category.Remove(category);
                return context.SaveChanges() > 0;
                
            }
            return false;   
        }

        public async Task<Category> GetCategoryAsync(int Id)
        {
            var category = await context.Category.AsNoTracking().Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (category == null) {
                return new Category();
            }
            return category;
        }

        public async Task<Category> UpdateAsync(Category obj)
        {
            var category = await context.Category.FirstOrDefaultAsync(x => x.Id == obj.Id);
            if (category is not null) { 
                category.Name = obj.Name;
                context.Update(category);
                context.SaveChanges();
                return category; 
            }
            return obj;
        }
    }
}
