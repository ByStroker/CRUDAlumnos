﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class NEstado
    {
        private DEstado _DEstado = new DEstado();
        public List<Estado> Consultar() => _DEstado.Consultar();
        public Estado Consultar(int id) => _DEstado.Consultar(id);
    }
}
