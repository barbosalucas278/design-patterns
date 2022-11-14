using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainsOfResponsability.Models
{
    public class AprobadorDeCompras
    {
        Comprador _comprador;
        Gerente _gerente;
        Director _director;
        DirectorGeneral _directorGeneral;

        public AprobadorDeCompras()
        {
            _comprador = new Comprador();
            _gerente = new Gerente();
            _director = new Director();
            _directorGeneral = new DirectorGeneral();

            GenerarChainOfResponsability();
        }

        private void GenerarChainOfResponsability()
        {
            _comprador.AgregarSiguiente(_gerente);
            _gerente.AgregarSiguiente(_director);
            _director.AgregarSiguiente(_directorGeneral);
        }
        public void ProcesarCompra(Compra compra)
        {
            _comprador.Procesar(compra);
        }
    }
}
