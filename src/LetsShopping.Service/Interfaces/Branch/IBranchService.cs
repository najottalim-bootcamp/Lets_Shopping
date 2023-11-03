using LetsShopping.Domain.Models.Branch;
using LetsShopping.Service.Dtos.BranchDtos;


namespace LetsShopping.Service.Interfaces
{
    public interface IBranchService
    {
        public ValueTask CreateBranchAsync(Branch branch);
        public ValueTask<Branch> GetCompanyByIdAsync(int Id);
        public ValueTask<List<Branch>> GetAllBranchAsync();
        public ValueTask UpdateCompanyAsync(int  Id, Branch newBranch);
        public ValueTask DeleteBranchAsync(int Id);
    }
}
