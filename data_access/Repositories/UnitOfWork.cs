using data_access.Entities;
using SteamApplication.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace data_access.Repositories
{
    public interface IUoW
    {
        public IRepository<Country>? CountryRepo { get; }
        public IRepository<Game>? GameRepo { get; }
        public IRepository<Groups> GroupRepo { get; }
        public IRepository<Platform>? PlatformRepo { get; }
        public IRepository<Position>? PosRepo { get; }
        public IRepository<Review>? ReviewRepo { get; }
        public IRepository<User>? UserRepo { get; }

        void Save();
    }

    public class UnitOfWork : IUoW, IDisposable
    {
        
        private static SteamDb context = new SteamDb();

        private IRepository<Category>? categoryRepo = null;
        private IRepository<Company>? companyRepo = null;
        private IRepository<Country>? countryRepo = null;
        private IRepository<Game>? gameRepo = null;
        private IRepository<Groups>? groupRepo = null;
        private IRepository<Platform>? platformRepo = null;
        private IRepository<Position>? posRepo = null;
        private IRepository<Review>? reviewRepo = null;
        private IRepository<User>? userRepo = null;

        public IRepository<Category> CategoryRepo
        {
            get
            {

                if (this.categoryRepo == null)
                {
                    this.categoryRepo = new Repository<Category>(context);
                }
                return categoryRepo;
            }
        }

        public IRepository<Company> CompanyRepo
        {
            get
            {

                if (this.companyRepo == null)
                {
                    this.companyRepo = new Repository<Company>(context);
                }
                return companyRepo;
            }
        }
        public IRepository<Country> CountryRepo
        {
            get
            {

                if (this.countryRepo == null)
                {
                    this.countryRepo = new Repository<Country>(context);
                }
                return countryRepo;
            }
        }

        public IRepository<Game> GameRepo
        {
            get
            {

                if (this.gameRepo == null)
                {
                    this.gameRepo = new Repository<Game>(context);
                }
                return gameRepo;
            }
        }
        public IRepository<Platform> PlatformRepo
        {
            get
            {

                if (this.platformRepo == null)
                {
                    this.platformRepo = new Repository<Platform>(context);
                }
                return platformRepo;
            }
        }

        public IRepository<Position> PosRepo
        {
            get
            {
                if (this.posRepo == null)
                {
                    this.posRepo = new Repository<Position>(context);
                }
                return posRepo;
            }
        }
        public IRepository<Review> ReviewRepo
        {
            get
            {
                if (this.reviewRepo == null)
                {
                    this.reviewRepo = new Repository<Review>(context);
                }
                return reviewRepo;
            }
        }
      
        public IRepository<Groups> GroupRepo
        {
            get
            {
                if (this.groupRepo == null)
                {
                    this.groupRepo = new Repository<Groups>(context);
                }
                return groupRepo;
            }
        }

        public IRepository<User> UserRepo
        {
            get
            {
                if(this.userRepo == null)
                {
                    this.userRepo = new Repository<User>(context);
                }
                return userRepo;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
