using HelpStockApp.Application.DTOs;

namespace HelpStockApp.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategories();
        Task<CategoryDTO> GetAllCategoryById(int? id);
        Task Add(CategoryDTO categoryDto);

        Task Update(CategoryDTO categoryDto);

        Task Remove(int? id);

    }
}
