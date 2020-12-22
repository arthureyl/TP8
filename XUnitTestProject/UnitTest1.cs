using System;
using TP8;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        BuilderTest builderTest = new BuilderTest();

        [Fact]
        public void TestFormuleRepas()
        {
            BDE bde = builderTest.genererBDE();

            PreparateurFormule formule = new PreparateurFormule();
            formule.PreparationRepas1(bde.Stock);
            Assert.Equal(0,bde.Stock.GetStockProduitByName("soda")) ;
        }
    }
}
