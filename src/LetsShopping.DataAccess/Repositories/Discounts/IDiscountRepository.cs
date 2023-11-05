﻿using LetsShopping.Domain.Dtos.DiscountDtos;

namespace LetsShopping.DataAccess.Repositories.Discount
{
    public interface IDiscountRepository : IBaseRepository<Domain.Models.Discount.Discount, DiscountDto>
    {
    }
}
