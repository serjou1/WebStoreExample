using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebStoreExample.DAL.Entities
{
    public class CategoryDal
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<GoodsDal> Goods { get; set; }
    }
}
