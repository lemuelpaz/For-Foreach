using System;
using Xunit;

namespace For.Tests
{
    public class IteracaoTests
    {
        [Fact]
        public void For_DeveIterarCincoVezes()
        {
            int totalIteracoes = 0;

            for (int i = 0; i < 5; i++)
            {
                totalIteracoes++;
            }

            Assert.Equal(5, totalIteracoes);
        }

        [Fact]
        public void For_DeveIniciarEmZero()
        {
            int primeiroValor = -1;

            for (int i = 0; i < 5; i++)
            {
                primeiroValor = i;
                break;
            }

            Assert.Equal(0, primeiroValor);
        }

        [Fact]
        public void For_DeveTerminarEmQuatro()
        {
            int ultimoValor = -1;

            for (int i = 0; i < 5; i++)
            {
                ultimoValor = i;
            }

            Assert.Equal(4, ultimoValor);
        }

        [Fact]
        public void Foreach_DeveIterarSobreTodosOsElementosDoArray()
        {
            string[] valores = { "Vinte", "Trinta", "Quarenta" };
            int totalIteracoes = 0;

            foreach (string y in valores)
            {
                totalIteracoes++;
            }

            Assert.Equal(3, totalIteracoes);
        }

        [Fact]
        public void Foreach_DeveConterElementoVinte()
        {
            string[] valores = { "Vinte", "Trinta", "Quarenta" };

            Assert.Contains("Vinte", valores);
        }

        [Fact]
        public void Foreach_DeveConterElementoTrinta()
        {
            string[] valores = { "Vinte", "Trinta", "Quarenta" };

            Assert.Contains("Trinta", valores);
        }

        [Fact]
        public void Foreach_DeveConterElementoQuarenta()
        {
            string[] valores = { "Vinte", "Trinta", "Quarenta" };

            Assert.Contains("Quarenta", valores);
        }

        [Fact]
        public void Foreach_DeveRetornarElementosNaOrdemCorreta()
        {
            string[] valores = { "Vinte", "Trinta", "Quarenta" };
            string[] resultado = new string[valores.Length];
            int indice = 0;

            foreach (string y in valores)
            {
                resultado[indice++] = y;
            }

            Assert.Equal("Vinte", resultado[0]);
            Assert.Equal("Trinta", resultado[1]);
            Assert.Equal("Quarenta", resultado[2]);
        }

        [Fact]
        public void Foreach_ArrayVazio_NaoDeveIterar()
        {
            string[] valores = Array.Empty<string>();
            int totalIteracoes = 0;

            foreach (string y in valores)
            {
                totalIteracoes++;
            }

            Assert.Equal(0, totalIteracoes);
        }

        [Fact]
        public void For_ComLimiteZero_NaoDeveIterar()
        {
            int totalIteracoes = 0;

            for (int i = 0; i < 0; i++)
            {
                totalIteracoes++;
            }

            Assert.Equal(0, totalIteracoes);
        }
    }
}