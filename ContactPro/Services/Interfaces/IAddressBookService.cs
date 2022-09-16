using ContactPro.Models;

namespace ContactPro.Services.Interfaces
{
  public interface IAddressBookService
  {
    Task AddContactToCategoryAsync(int categoryId, int contactId);
    Task<bool> IsContactInCategory(int categoryId, int contactId);
    Task<IEnumerable<Category>> GetUserCategoriesAsync(string userId);
    Task<ICollection<int>> GetContactCategoryIdsAsync(int contactId);
    Task<ICollection<Category>> GetContactCategoriesAsync(string contactId);
    Task RemoveContactFromCategoryAsync(int categoryId, int contactId);
    IEnumerable<Contact> SearchForContact(string searchString, string userId);
  }
}
