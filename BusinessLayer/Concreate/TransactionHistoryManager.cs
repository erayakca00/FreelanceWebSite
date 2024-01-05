using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class TransactionHistoryManager : ITransactionHistoryService
    {
        ITransactionHistoryDal _transactionHistoryDal;

        public TransactionHistoryManager(ITransactionHistoryDal transactionHistoryDal)
        {
            _transactionHistoryDal = transactionHistoryDal;   
                
        }

        public void TAdd(TransactionHistory t)
        {
            _transactionHistoryDal.Insert(t);
        }

        public TransactionHistory TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TransactionHistory> TGetList()
        {
            return _transactionHistoryDal.GetList();
        }

        public void TRemove(TransactionHistory t)
        {
            _transactionHistoryDal.Delete(t);
        }

        public void TUpdate(TransactionHistory t)
        {
            _transactionHistoryDal.Update(t);         
        }
    }
}
