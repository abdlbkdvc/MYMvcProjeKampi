using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {
        Context _context = new Context();
        IContentDal _contentDal;
        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }
        public void ContentAddBL(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingIdi(int id)
        {

            return _contentDal.List(x => x.HeadingID == id)
    .Where(x => x.HeadingID == id)
    .Select(h => new Content
    {
        ContentID = h.ContentID,
        ContentValue = h.ContentValue,
        ContentDate = h.ContentDate,
        WriterID = h.WriterID,
        Writer = _context.Writers.FirstOrDefault(w => w.WriterID == h.WriterID),
        HeadingID = h.HeadingID,
        Heading = _context.Headings.FirstOrDefault(c => c.HeadingID == h.HeadingID),
    }).ToList();
        }

        public List<Content> GetListByHeadingID(int id)
        {
            throw new NotImplementedException();
        }
    }
}