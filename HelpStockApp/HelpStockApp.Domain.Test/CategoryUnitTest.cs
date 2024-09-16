using FluentAssertions;
using HelpStockApp.Domain.Entities;
using HelpStockApp.Domain.Validation;
using Xunit;

namespace HelpStockApp.Domain.Test
{
    public class CategoryUnitTest
    {
        #region Testes Positivos de Categoria
        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectsValidState()
        {
            Action action = () => new Category(1, "Eletronics");
            action.Should().NotThrow<DomainExceptionValidation>();
        }
        #endregion

        #region Testes Negativos de Categoria
        [Fact(DisplayName = "Create Category With Invalid Id")]
        public void CreateCategory_WithInvalidParametersId_ResultException()
        {
            Action action = () => new Category(-1, "Eletronics");
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid Id value");
        }
        #endregion

        
    }
}
