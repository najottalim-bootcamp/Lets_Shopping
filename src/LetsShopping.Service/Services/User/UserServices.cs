﻿using LetsShopping.Domain.Dtos.CardDtos;
using LetsShopping.Domain.Dtos.CartsDtos;
using LetsShopping.Domain.Dtos.UsersDtos;
using LetsShopping.Domain.Models.Cards;
using LetsShopping.Domain.Models.Carts;
using LetsShopping.Domain.Models.Category;


namespace LetsShopping.Service.Services.User
{
    public class UserServices : UserServicesBase, IUserService
    {
        public ValueTask<int> CreateCardAsync(CardDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> CreateCartAsync(CartDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteCardAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteCartAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteUserAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> DeleteUserByIdAsync(int UserId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Card>> GetAllCardAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Cart>> GetAllCartAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Category>> GetAllCategory()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Domain.Models.Companies.Company>> GetAllCompany()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<OrderDto>> GetAllOrderByUserId()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Product>> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Domain.Models.Users.User>> GetAllUserAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Card> GetCardByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Cart> GetCartByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Domain.Models.Users.User> GetUserByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateCardAsync(int Id, CardDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateCartAsync(int Id, CartDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateUserAsync(int Id, UsersDto model)
        {
            throw new NotImplementedException();
        }

        ValueTask<IList<Order>> IUserService.GetAllOrderByUserId()
        {
            throw new NotImplementedException();
        }
    }
}
