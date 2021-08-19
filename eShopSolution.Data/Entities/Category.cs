using eShopSolution.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOder { get; set; }
        public bool isShowOnHome { get; set; }
        public int? Parentid { get; set; }
        public Status Status { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
