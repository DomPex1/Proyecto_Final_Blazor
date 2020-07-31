﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudioEF.BLL;
using StudioEF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudioEF.BLL.Tests
{
    [TestClass()]
    public class ComprasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {


            Compras compras = new Compras
            {
                CompraId = 0,
                UsuarioId = 1,
                Monto = 0
            };
            compras.ComprasDetalle.Add(new ComprasDetalle
            {
                ComprasDetalleId = 0,
                CompraId = compras.CompraId,
                ArticuloId = 1,
                Descripcion = "Carro",
                CantidadArticulos = 2
            }) ;

            Assert.IsTrue(ComprasBLL.Guardar(compras));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = ComprasBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Compras compras;
            compras = ComprasBLL.Buscar(1);
            Assert.IsNotNull(compras);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Compras>();
            lista = ComprasBLL.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}