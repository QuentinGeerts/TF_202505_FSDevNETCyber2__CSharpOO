using DemoGeneric2.Models;

UserRepository userRepository = new UserRepository();

User user1 = new User() { Id = Guid.NewGuid(), Name = "Quentin" };
User user2 = new User() { Id = Guid.NewGuid(), Name = "Samuel" };
User user3 = new User() { Id = Guid.NewGuid(), Name = "Robin" };
User user4 = new User() { Id = Guid.NewGuid(), Name = "Mauritcio" };
User user5 = new User() { Id = Guid.NewGuid(), Name = "Michael" };

userRepository.Add(user1);
userRepository.Add(user2);
userRepository.Add(user3);
userRepository.Add(user4);
userRepository.Add(user5);

User? findUser1 = userRepository.FindById(user1.Id);
User? findUser2 = userRepository.FindById(Guid.NewGuid());

Console.WriteLine($"findUser1: {findUser1?.Id} - {findUser1?.Name} - {findUser1?.CreatedAt}");
Console.WriteLine($"findUser2: {findUser2?.Id} - {findUser2?.Name} - {findUser2?.CreatedAt}");


ProductRepository productRepository = new ProductRepository();

Product product1 = new Product() { Id = Guid.NewGuid(), Name = "Pasta", Price = 0.3 };
Product product2 = new Product() { Id = Guid.NewGuid(), Name = "Pizza", Price = 2.3 };
Product product3 = new Product() { Id = Guid.NewGuid(), Name = "Mozzarella", Price = 1.8 };
Product product4 = new Product() { Id = Guid.NewGuid(), Name = "Lasagne", Price = 2.58 };
Product product5 = new Product() { Id = Guid.NewGuid(), Name = "Sandwich", Price = 3.2 };

productRepository.Add(product1);
productRepository.Add(product2);
productRepository.Add(product3);
productRepository.Add(product4);
productRepository.Add(product5);

Product? findProduct1 = productRepository.FindById(product1.Id);
Product? findProduct2 = productRepository.FindById(Guid.NewGuid());

Console.WriteLine($"findProduct1: {findProduct1?.Id} - {findProduct1?.Name} - {findProduct1?.CreatedAt}");
Console.WriteLine($"findProduct2: {findProduct2?.Id} - {findProduct2?.Name} - {findProduct2?.CreatedAt}");


Repository<Product> productRepo = new Repository<Product>();
Repository<User> userRepo = new Repository<User>();

productRepo.Add(product1);
productRepo.Add(product2);
productRepo.Add(product3);
productRepo.Add(product4);
productRepo.Add(product5);

userRepo.Add(user1);
userRepo.Add(user2);
userRepo.Add(user3);
userRepo.Add(user4);
userRepo.Add(user5);

Repository<Category> categoryRepository = new Repository<Category>();
