using Pay1193.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay1193.Service
{
    public interface IEmployee
    {
        Task CreateAsync(Employee employee);
        Employee GetById(int id);
        Task UpdateAsync(Employee employee);
        Task UpdateAsync(int id);
        Task DeleteAsync(int id);
        decimal UnionFee(int id);
        decimal StudentLoanRepaymentAmount(int id, decimal totalAmount);

        IEnumerable<Employee> GetAll();
    }
}
