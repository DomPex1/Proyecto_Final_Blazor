﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudioEF.BLL;
using StudioEF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudioEF.BLL.Tests
{
    [TestClass()]
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = 0;
            usuarios.Nombres = "";
            usuarios.NombreUsuario = "";
            usuarios.Contrasena = "";
            usuarios.Email = "";

            Assert.IsTrue(UsuariosBLL.Guardar(usuarios));
        }

        [TestMethod()]
        public void EncriptarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = UsuariosBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Usuarios usuarios;
            usuarios = UsuariosBLL.Buscar(1);
            Assert.IsNotNull(usuarios);
        }

        [TestMethod()]
        public void DesEncriptarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ExisteUsuarioTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ObtenerUsuarioIdTest()
        {
            Assert.Fail();
        }
    }
}