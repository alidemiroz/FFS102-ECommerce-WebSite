using System;
namespace ECApp_Data
{
	public class ViewModels
	{
		public List<CartItem> CartItem { get; set; }
        public List<Category> Category { get; set; }
        public List<Order> Order { get; set; }
        public List<OrderItem> OrderItem { get; set; }
        public List<Product> Product { get; set; }
        public List<ProductComment> ProductComment { get; set; }
        public List<ProductImage> ProductImage { get; set; }
        public List<Role> Role { get; set; }
        public List<User> User { get; set; }
    }
}

