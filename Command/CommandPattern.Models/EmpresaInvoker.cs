using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Models
{
    public class EmpresaInvoker
    {
        private List<OrdenCommand> _ordenes = new List<OrdenCommand>();
        public void TomarOrden(OrdenCommand orden)
        {
            _ordenes.Add(orden);
        }
        public void ProcesarOrdens()
        {
            foreach (var orden in _ordenes)
            {
                orden.Ejecutar();
            }
            _ordenes.Clear();
        }
    }
}
