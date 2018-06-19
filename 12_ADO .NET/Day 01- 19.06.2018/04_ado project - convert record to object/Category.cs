

namespace _04_ado_project
{
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public Category(int categoryId, string categoryName, string description)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            Description = description;
        }

        public override string ToString()
        {
            return $"CategoryId: {CategoryId}, CategoryName: {CategoryName}, Description: {Description} ";
        }
    }
}
