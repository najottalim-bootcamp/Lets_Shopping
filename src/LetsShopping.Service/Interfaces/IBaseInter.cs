using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Service.Interfaces
{
    public interface IBaseInter<TModel,TDto> 
    {
        public ValueTask<bool> Create(TDto dto);
        public ValueTask<bool> Update(int id, TDto dto);
        public ValueTask<bool> Delete(int id);
        public ValueTask<List<TModel>> GetAll(string Tablename);
        public ValueTask<TModel> GetById(int id, string Tablename);
    }
}
