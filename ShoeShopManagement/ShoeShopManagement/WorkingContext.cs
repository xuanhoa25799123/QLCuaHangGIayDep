using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain;
using ShoeShopManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement
{
    public sealed class WorkingContext
    {
        private static WorkingContext _instance = null;

        public static WorkingContext Instance => _instance ?? (_instance = new WorkingContext());

        private ShoeShopContext _dbContext = null;

        private IUnitOfWork _unitOfWork;

        private string _currentConnectionString;

        public LoginModel CurrentLoginInfo { get; set; }

        public int currentBranchId { get; set; }

        public string currentBranch { get; set; }

        public string currentLoginName { get; set; }

        private WorkingContext()
        { }

        public void Initialize(string connectionString)
        {
            _currentConnectionString = connectionString;
            _dbContext = new ShoeShopContext(_currentConnectionString);
            _unitOfWork = new UnitOfWork(_dbContext);
        }

        public IUnitOfWork GetUnitOfWork()
        {
            return _unitOfWork;
        }

  
    }
}
