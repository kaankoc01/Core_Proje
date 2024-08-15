using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDal _writerUserDal;

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public void TAdd(WriteUser t)
        {
            _writerUserDal.Insert(t);
        }

        public void TDelete(WriteUser t)
        {
             _writerUserDal.Delete(t);
        }

        public WriteUser TGetByID(int id)
        {
            return _writerUserDal.GetByID(id);
        }

        public List<WriteUser> TGetList()
        {
            return _writerUserDal.GetList();
        }

        public List<WriteUser> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriteUser t)
        {
            _writerUserDal.Update(t);
        }
    }
}
