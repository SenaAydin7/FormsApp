namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category {CategoryId=1, Name = "Sedan"});
            _categories.Add(new Category {CategoryId=2, Name = "Coupe"});

            _products.Add(new Product {ProductId=1,Name = "BMW 5",Price=3885700, IsActive=true,Image="Img1.png",CategoryId=1});
            _products.Add(new Product {ProductId=2,Name = "BMW 4 Gran",Price=3324100, IsActive=false,Image="Img2.png",CategoryId=2});
            _products.Add(new Product {ProductId=3,Name = "BMW M3 Competiton",Price=2959700, IsActive=true,Image="Img3.png",CategoryId=1});
            _products.Add(new Product {ProductId=7,Name = "BMW M4",Price=5135000, IsActive=false,Image="Img7.png",CategoryId=2});
            _products.Add(new Product {ProductId=4,Name = "BMW M5",Price=3940900, IsActive=true,Image="Img4.png",CategoryId=1});
            _products.Add(new Product {ProductId=5,Name = "BMW M8 Gran",Price=12650900, IsActive=true,Image="Img5.png",CategoryId=2});
            _products.Add(new Product {ProductId=6,Name = "BMW M8",Price=11915200, IsActive=true,Image="Img6.png",CategoryId=2});
        }
        public static List<Product>Products
        {
            get
            {
                return _products;
            }
        }

        public static void DeleteProduct(Product deletedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == deletedProduct.ProductId);

            if(entity != null)
            {
                _products.Remove(entity);
            }
        }

        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }

        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if(entity != null)
            {
                if(!string.IsNullOrEmpty(updatedProduct.Name))
                {
                    entity.Name = updatedProduct.Name;
                }
                entity.Price = updatedProduct.Price;
                entity.Image = updatedProduct.Image;
                entity.CategoryId = updatedProduct.CategoryId;
                entity.IsActive = updatedProduct.IsActive;
            }
        }
        public static void EditIsActive(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if(entity != null)
            {
                entity.IsActive = updatedProduct.IsActive;
            }
        }

        public static List<Category> Categories
        {
            get
            {
                 return _categories;
            }
        }
    }
}
