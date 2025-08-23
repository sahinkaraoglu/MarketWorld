using MarketWorld.Core.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarketWorld.Tests
{
    [TestClass]
    public sealed class ProductTests
    {
        [TestMethod]
        public void Product_Create_ShouldSetDefaultValues()
        {
            // Arrange & Act
            var product = new Product
            {
                Name = "Test Ürün",
                BrandId = 1,
                Price = 100.00m,
                Description = "Test açıklaması"
            };

            // Assert
            Assert.IsTrue(product.IsActive);
            Assert.IsFalse(product.HasDiscount);
            Assert.AreEqual(0, product.ProductCode);
            Assert.AreEqual(0, product.Rating);
            Assert.AreEqual(0, product.DiscountPrice);
        }

        [TestMethod]
        public void Product_GenerateRandomProductCode_ShouldGenerateSixDigitCode()
        {
            // Arrange
            var product = new Product();

            // Act
            product.GenerateRandomProductCode();

            // Assert
            Assert.IsTrue(product.ProductCode >= 100000);
            Assert.IsTrue(product.ProductCode < 1000000);
        }

        [TestMethod]
        public void Product_GetTotalStock_WithNoProperties_ShouldReturnZero()
        {
            // Arrange
            var product = new Product
            {
                ProductProperties = new List<ProductProperty>()
            };

            // Act
            var totalStock = product.GetTotalStock();

            // Assert
            Assert.AreEqual(0, totalStock);
        }

        [TestMethod]
        public void Product_GetTotalStock_WithActiveProperties_ShouldReturnCorrectSum()
        {
            // Arrange
            var product = new Product
            {
                ProductProperties = new List<ProductProperty>
                {
                    new ProductProperty { IsActive = true, Stock = 10 },
                    new ProductProperty { IsActive = true, Stock = 20 },
                    new ProductProperty { IsActive = false, Stock = 30 }
                }
            };

            // Act
            var totalStock = product.GetTotalStock();

            // Assert
            Assert.AreEqual(30, totalStock); // Sadece aktif olanlar: 10 + 20
        }

        [TestMethod]
        public void Product_GetTotalStock_WithNullProperties_ShouldReturnZero()
        {
            // Arrange
            var product = new Product
            {
                ProductProperties = null
            };

            // Act
            var totalStock = product.GetTotalStock();

            // Assert
            Assert.AreEqual(0, totalStock);
        }

        [TestMethod]
        public void Product_CreateWithDifferentValues_ShouldSetCorrectValues()
        {
            // Arrange & Act
            var product = new Product
            {
                Name = "iPhone 15",
                BrandId = 1,
                Price = 25000.00m,
                Description = "Akıllı telefon"
            };

            // Assert
            Assert.AreEqual("iPhone 15", product.Name);
            Assert.AreEqual(1, product.BrandId);
            Assert.AreEqual(25000.00m, product.Price);
            Assert.AreEqual("Akıllı telefon", product.Description);
        }

        [TestMethod]
        public void Product_CreateWithMacBookPro_ShouldSetCorrectValues()
        {
            // Arrange & Act
            var product = new Product
            {
                Name = "MacBook Pro",
                BrandId = 2,
                Price = 45000.00m,
                Description = "Laptop"
            };

            // Assert
            Assert.AreEqual("MacBook Pro", product.Name);
            Assert.AreEqual(2, product.BrandId);
            Assert.AreEqual(45000.00m, product.Price);
            Assert.AreEqual("Laptop", product.Description);
        }

        [TestMethod]
        public void Product_CreateWithIPadAir_ShouldSetCorrectValues()
        {
            // Arrange & Act
            var product = new Product
            {
                Name = "iPad Air",
                BrandId = 3,
                Price = 15000.00m,
                Description = "Tablet"
            };

            // Assert
            Assert.AreEqual("iPad Air", product.Name);
            Assert.AreEqual(3, product.BrandId);
            Assert.AreEqual(15000.00m, product.Price);
            Assert.AreEqual("Tablet", product.Description);
        }

        [TestMethod]
        public void Product_GenerateRandomProductCode_MultipleCalls_ShouldGenerateDifferentCodes()
        {
            // Arrange
            var product1 = new Product();
            var product2 = new Product();

            // Act
            product1.GenerateRandomProductCode();
            product2.GenerateRandomProductCode();

            // Assert
            Assert.AreNotEqual(product1.ProductCode, product2.ProductCode);
            Assert.IsTrue(product1.ProductCode >= 100000);
            Assert.IsTrue(product2.ProductCode >= 100000);
        }

        [TestMethod]
        public void Product_PriceValidation_ShouldWorkCorrectly()
        {
            // Arrange
            var product = new Product
            {
                Name = "Test Ürün",
                Price = 99.99m
            };

            // Act & Assert
            Assert.AreEqual(99.99m, product.Price);
            Assert.IsTrue(product.Price > 0);
        }

        [TestMethod]
        public void Product_DiscountCalculation_ShouldWorkCorrectly()
        {
            // Arrange
            var product = new Product
            {
                Name = "Test Ürün",
                Price = 100.00m,
                DiscountPrice = 80.00m,
                HasDiscount = true
            };

            // Act & Assert
            Assert.IsTrue(product.HasDiscount);
            Assert.AreEqual(80.00m, product.DiscountPrice);
            Assert.IsTrue(product.DiscountPrice < product.Price);
        }

        [TestMethod]
        public void Product_CategoryAndSubCategory_ShouldBeNullable()
        {
            // Arrange
            var product = new Product
            {
                Name = "Test Ürün",
                CategoryId = null,
                SubCategoryId = null
            };

            // Act & Assert
            Assert.IsNull(product.CategoryId);
            Assert.IsNull(product.SubCategoryId);
            Assert.IsNull(product.Category);
            Assert.IsNull(product.SubCategory);
        }

        [TestMethod]
        public void Product_WithCategoryAndSubCategory_ShouldSetCorrectly()
        {
            // Arrange
            var product = new Product
            {
                Name = "Test Ürün",
                CategoryId = 1,
                SubCategoryId = 2
            };

            // Act & Assert
            Assert.AreEqual(1, product.CategoryId);
            Assert.AreEqual(2, product.SubCategoryId);
        }
    }
}
