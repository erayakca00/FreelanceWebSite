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
    public class WalletManager : IWalletService
    {
        IWalletDal _walletDal;

        public WalletManager(IWalletDal walletDal)
        {
            _walletDal = walletDal;
        }
        public void TAdd(Wallet t)
        {
           _walletDal.Insert(t);
        }

        public Wallet TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Wallet> TGetList()
        {
            return _walletDal.GetList();
        }

        public void TRemove(Wallet t)
        {
           _walletDal.Delete(t);
        }

        public void TUpdate(Wallet t)
        {
            _walletDal.Update(t);
        }
    }
}
