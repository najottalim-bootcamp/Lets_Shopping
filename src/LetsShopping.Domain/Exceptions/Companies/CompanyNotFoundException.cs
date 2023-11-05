﻿namespace LetsShopping.Domain.Exceptions.Companies
{
    public class CompanyNotFoundException : NotFoundException
    {
        public CompanyNotFoundException()
        {
            this.TitleMessage = "Company not Found!";
        }
    }
}
