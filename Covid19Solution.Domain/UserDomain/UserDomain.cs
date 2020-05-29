using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using Covid19Solution.UnitOfWork.Main;
using Covid19Solution.Models.Main;
using RxWeb.Core.Security.Cryptography;

namespace Covid19Solution.Domain.UserModule
{
    public class UserDomain : IUserDomain
    {
        private IPasswordHash PasswordHash { get; set; }
        public UserDomain(IUserUow uow, IPasswordHash passwordHash) {
            this.Uow = uow;
             this.PasswordHash = passwordHash;
        }

        public Task<object> GetAsync(User user)
        {
            var userList = (object)Uow.Repository<User>().AllInclude(p => p.UserRoles);
            return Task.FromResult(userList);
        }

        public Task<object> GetBy(User parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(User entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(User entity)
        {
            PasswordResult result = PasswordHash.Encrypt(entity.UserPassword);
            entity.Password = result.Signature;
            entity.Salt = result.Salt;
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(User entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(User entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(User parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(User parameters)
        {
            throw new NotImplementedException();
        }

        public IUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IUserDomain : ICoreDomain<User,User> { }
}
