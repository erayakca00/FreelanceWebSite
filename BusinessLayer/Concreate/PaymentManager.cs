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
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }
        public void TAdd(Payment t)
        {
            _paymentDal.Insert(t);
        }

        public Payment TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Payment> TGetList()
        {
            return _paymentDal.GetList();
        }

        public void TRemove(Payment t)
        {
            _paymentDal.Delete(t);
        }

        public void TUpdate(Payment t)
        {
            _paymentDal.Update(t);  
        }
    }
}
