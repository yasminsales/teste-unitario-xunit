using System;
using Xunit;

namespace teste_unitario_07_05_21
{
    public class CarroTestes
    {
        [Fact]
        public void TestAcelerar()
        {
            Carro c1 = new Carro(1000, 0);
            c1.Acelerar();
            c1.Acelerar();
            c1.Acelerar();
            Assert.Equal(30, c1.Velocidade);
            
        }

        [Fact]
        public void TestFrear()
        {
            Carro c1 = new Carro(1000, 100);
            c1.Frear();
            Assert.Equal(0, c1.Velocidade);

        }

        [Fact]
        public void TestReduzir()
        {
            Carro c1 = new Carro(1000, 75);
            c1.Reduzir();
            Assert.Equal(5, c1.Velocidade);
        }
    }
}
