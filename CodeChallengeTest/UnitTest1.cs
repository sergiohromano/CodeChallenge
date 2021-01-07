using CodeChallenge.Data.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallengeTest
{
    public class Tests
    {
        private List<IAnimal> _animales;

        [SetUp]
        public void Setup()
        {
            _animales = new List<IAnimal>();
        }

        [Test]
        public void CalcularAlimentoSinAnimales()
        {
            var result = _animales.Sum(a => a.CalcularAlimento());
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CalcularAlimentoSoloCarnivoros()
        {
            _animales.AddRange(MockFactoryCarnivoros());
            var result = _animales.Sum(a => a.CalcularAlimento());
            Assert.AreEqual(22.5, result);
        }

        [Test]
        public void CalcularAlimentoSoloHerbivoros()
        {
            _animales.AddRange(MockFactoryHerbivoros());
            var result = _animales.Sum(a => a.CalcularAlimento());
            Assert.AreEqual(185, result);
        }

        [Test]
        public void CalcularAlimentoSoloReptiles()
        {
            _animales.AddRange(MockFactoryReptiles());
            var result = _animales.Sum(a => a.CalcularAlimento());
            Assert.AreEqual(14, result);
        }

        [Test]
        public void CalcularAlimentoTodos()
        {
            _animales.AddRange(MockFactoryTodos());
            var result = _animales.Sum(a => a.CalcularAlimento());
            Assert.AreEqual(210.5, result);
        }

        [Test]
        public void CalcularAlimentoSoloCarnivorosCarneMensual()
        {
            var hoy = new DateTime(2021, 1, 7);
            _animales.AddRange(MockFactoryCarnivoros());
            var result = _animales.Sum(a => a.CalcularAlimentoCarneMensual(hoy));
            Assert.AreEqual(697.5, result);
        }

        [Test]
        public void CalcularAlimentoSoloCarnivorosHierbaMensual()
        {
            var hoy = new DateTime(2021, 1, 7);
            _animales.AddRange(MockFactoryCarnivoros());
            var result = _animales.Sum(a => a.CalcularAlimentoHierbaMensual(hoy));
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CalcularAlimentoSoloReptilesCarneMensual()
        {
            var hoy = new DateTime(2021, 1, 7);
            _animales.AddRange(MockFactoryReptiles());
            var result = _animales.Sum(a => a.CalcularAlimentoCarneMensual(hoy));
            Assert.AreEqual(33, result);
        }

        [Test]
        public void CalcularAlimentoSoloReptilesHierbaMensual()
        {
            var hoy = new DateTime(2021, 1, 7);
            _animales.AddRange(MockFactoryReptiles());
            var result = _animales.Sum(a => a.CalcularAlimentoHierbaMensual(hoy));
            Assert.AreEqual(11, result);
        }
        #region Mock Factory
        private List<Animal> MockFactoryCarnivoros()
        {
            return new List<Animal>() {
                new Carnivoro{
                    Peso = 100,
                    PorcentajeCarne = 0.05
                },
                new Carnivoro{
                    Peso = 80,
                    PorcentajeCarne = 0.1
                },
                new Carnivoro{
                    Peso = 95,
                    PorcentajeCarne = 0.1
                }
            };
        }

        private List<Animal> MockFactoryHerbivoros()
        {
            return new List<Animal>() {
                new Herbivoro{
                    Peso = 30,
                    Kilos = 10
                },
                new Herbivoro{
                    Peso = 50,
                    Kilos = 15
                }
            };
        }
        private List<Animal> MockFactoryReptiles()
        {
            return new List<Animal>() {
                new Reptil{
                    Peso = 10,
                    PorcentajeCarne = 0.7,
                    PorcentajeHierba = 0,
                    CambioDePiel = 7
                },
                new Reptil{
                    Peso = 10,
                    PorcentajeCarne = 0.35,
                    PorcentajeHierba = 0.35,
                    CambioDePiel = 6
                }
            };
        }

        private List<Animal> MockFactoryTodos()
        {
            return new List<Animal>() {
                new Carnivoro{
                    Peso = 100,
                    PorcentajeCarne = 0.05
                },
                new Carnivoro{
                    Peso = 80,
                    PorcentajeCarne = 0.1
                },
                new Carnivoro{
                    Peso = 95,
                    PorcentajeCarne = 0.1
                },
                new Herbivoro{
                    Peso = 30,
                    Kilos = 10
                },
                new Herbivoro{
                    Peso = 50,
                    Kilos = 15
                },
                new Reptil{
                    Peso = 10,
                    PorcentajeCarne = 0.1,
                    PorcentajeHierba = 0.2
                },
            };
        }
        #endregion
    }
}