using FluentAssertions;
using HelpStockApp.Domain.Entities;
using HelpStockApp.Domain.Validation;
using Xunit;

namespace HelpStockApp.Domain.Test
{
    public class ProductUnitTest
    {
        #region Testes Positivos
        [Fact(DisplayName = "Create Product With Valid State")]
        public void CreateProduct_WithValidParemeters_ResultObejectsValidState()
        {
            Action action = () => new Product(1, "Eletronics", "Notebook", 1999, 100, "silver.png");
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With No Id")]
        public void CreateProduct_WithNoIdParemeters_ResultObejectsValidState()
        {
            Action action = () => new Product("Eletronics", "Notebook", 1999, 100, "silver.png");
            action.Should().NotThrow<DomainExceptionValidation>();
        }
        #endregion

        #region Testes Negativos
        [Fact(DisplayName = "Create Product With Invalid Id")]
        public void CreateProduct_WithInvalidParemetersId_ResultException()
        {
            Action action = () => new Product(-1, "Eletronics", "Notebook", 1999, 100, "silver.png");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid Id value.");
        }

        [Fact(DisplayName = "Create Product With Empty Name Parameter")]
        public void CreateProduct_WithEmptyNameParameter_ResultException()
        {
            Action action = () => new Product(1, "", "Notebook", 1999, 100, "silver.png");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required!");
        }

        [Fact(DisplayName = "Create Product With Null Name Parameter")]
        public void CreateProduct_WithNullNameParameter_ResultException()
        {
            Action action = () => new Product(1, null, "Notebook", 1999, 100, "silver.png");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required!");
        }

        [Fact(DisplayName = "Create Product With Name Too Short Parameter")]
        public void CreateProduct_WithNameTooShortParameter_ResultException()
        {
            Action action = () => new Product(1, "ab", "Notebook", 1999, 100, "silver.png");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid name, too short. minimum 3 characters!");
        }


        [Fact(DisplayName = "Create Product With Image Too Long")]
        public void CreateProduct_WithImageTooLongParameter_ResultException()
        {
            Action action = () => new Product(1, "Eletronics", "Notebook", 1999, 100,"silver.pngaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid image URL, too long. maximum 250 characters!");
        }

        [Fact(DisplayName = "Create Product with Image Null")]
        public void CreateProduct_WithImageNull_ResultException()
        {
            Action action = () => new Product(1, "Eletronics", "Notebook", 1999, 100, null);
            action.Should().Throw<System.NullReferenceException>();
        }
        [Fact(DisplayName ="Create Product with Image Empty")]
        public void CreateProduct_WithImageEmpty_ResultException()
        {
            Action action = () => new Product(1,"Eletronics","Notebook",1999,100,string.Empty);
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid image. Image is required");
        }

        [Fact(DisplayName = "Create Product with Invalid Stock")]
        public void CreateProduct_WithInvalidStock_ResultException()
        {
            Action action = () => new Product(1, "Eletronics", "Notebook", 1999, -1, "silver.png");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid Stock, stock negative value is unlikely!");
        }

        [Fact(DisplayName = "Create Product with Invalid Price")]
        public void CreateProduct_WithInvalidPrice_ResultException()
        {
            Action action = () => new Product(1, "Eletronics", "Notebook", -1999, 100, "silver.png");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid Price, price negative value is unlikely!");
        }

        [Fact(DisplayName = "Create Product With Empty Description Parameter")]
        public void CreateProduct_WithEmptyDescriptionParameter_ResultException()
        {
            Action action = () => new Product(1, "Eletronnics", "", 1999, 100, "silver.png");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid description, description is required!");
        }

        [Fact(DisplayName = "Create Product With Null Description Parameter")]
        public void CreateProduct_WithNullDescriptionParameter_ResultException()
        {
            Action action = () => new Product(1, "Eletronics", null, 1999, 100, "silver.png");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid description, description is required!");
        }

        [Fact(DisplayName = "Create Product With Description Too Short Parameter")]
        public void CreateProduct_WithDescriptionTooShortParameter_ResultException()
        {
            Action action = () => new Product(1, "Eletronics", "Note", 1999, 100, "silver.png");
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid description, too short. minimum 5 characters!");
        }
        #endregion

    }
}
