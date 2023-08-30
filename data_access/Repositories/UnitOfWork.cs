using data_access.Entities;
using SteamApplication.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Repositories
{
    public interface IUoW
    {

        public IRepository<Country>? CountryRepo { get; }

        public IRepository<Game>? GameRepo { get; }

        public IRepository<Groups>? GroupRepo { get; }

        public IRepository<Platform>? PlatformRepo { get; }

        public IRepository<Position>? PosRepo { get; }

        public IRepository<Review>? ReviewRepo { get; }

        public IRepository<User>? UserRepo { get; }
        void Save();
    }

    public class UnitOfWork : IDisposable
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

                if (this.CategoryRepo == null)
                {
                    this.categoryRepo = new Repository<Category>(context);
                }
                return CategoryRepo;
            }
        }

        public IRepository<Company> CompanyRepo
        {
            get
            {

                if (this.CompanyRepo == null)
                {
                    this.companyRepo = new Repository<Company>(context);
                }
                return CompanyRepo;
            }
        }
        public IRepository<Country> CountryRepo
        {
            get
            {

                if (this.CountryRepo == null)
                {
                    this.countryRepo = new Repository<Country>(context);
                }
                return CountryRepo;
            }
        }

        public IRepository<Game> GameRepo
        {
            get
            {

                if (this.GameRepo == null)
                {
                    this.gameRepo = new Repository<Game>(context);
                }
                return GameRepo;
            }
        }
        public IRepository<Platform> PlatformRepo
        {
            get
            {

                if (this.PlatformRepo == null)
                {
                    this.platformRepo = new Repository<Platform>(context);
                }
                return PlatformRepo;
            }
        }

        public IRepository<Position> PosRepo
        {
            get
            {
                if (this.PosRepo == null)
                {
                    this.posRepo = new Repository<Position>(context);
                }
                return PosRepo;
            }
        }
        public IRepository<Review> ReviewRepo
        {
            get
            {
                if (this.ReviewRepo == null)
                {
                    this.reviewRepo = new Repository<Review>(context);
                }
                return ReviewRepo;
            }
        }
        public IRepository<User> UserRepo
        {
            get
            {
                if (this.UserRepo == null)
                {
                    this.userRepo = new Repository<User>(context);
                }
                return UserRepo;
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
