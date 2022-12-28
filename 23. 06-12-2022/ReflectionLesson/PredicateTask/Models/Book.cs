using PredicateTask.Models.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateTask.Models
{
    public class Book : BaseModel
    {
        private static int _counter;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
        public string Code { get; set; }

        static Book()
        {
            _counter = 0;
        }

        public Book(string name, string authorName, int pageCount)
        {
            _counter++;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            for (int i = 0; i < Name.Split().Count(); i++)
                Code += Name.Split()[i][0].ToString().ToUpper();
            Code += _counter.ToString();

        }

        public override string ToString()
        {
            return $"Name: {Name} AuthorName: {AuthorName} Pagecount: {PageCount} Price: {Price} Code: {Code}";
        }
    }
}
