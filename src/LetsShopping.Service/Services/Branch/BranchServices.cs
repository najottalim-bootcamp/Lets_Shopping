namespace LetsShopping.Service.Services.Branch
{
    public class BranchServices : IBranchService
    {
        public ValueTask CreateBranchAsync(BranchDto branch)
        {
            throw new NotImplementedException();
        }

        public ValueTask DeleteBranchAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<Domain.Models.Branch.Branch>> GetAllBranchAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Domain.Models.Branch.Branch> GetCompanyByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask UpdateCompanyAsync(int Id, BranchDto newBranch)
        {
            throw new NotImplementedException();
        }
    }
}
