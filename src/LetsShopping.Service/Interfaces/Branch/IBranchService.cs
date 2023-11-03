using LetsShopping.Domain.Models.Branch;
using LetsShopping.Service.Dtos.BranchDtos;


namespace LetsShopping.Service.Interfaces
{
    public interface IBranchService
    {
        public ValueTask CreateBranchAsync(BranchDto branch);
        public ValueTask<Branch> GetCompanyByIdAsync(int Id);
        public ValueTask<List<Branch>> GetAllBranchAsync();
        public ValueTask UpdateCompanyAsync(int  Id, BranchDto newBranch);
        public ValueTask DeleteBranchAsync(int Id);
    }
}
