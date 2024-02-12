using System;
using System.Collections.Generic;
using System.Text;

namespace DependecyInjection
{
    class Musico
    {
        private IInstrumento instrumento;

        public Musico(IInstrumento instrumento)
        {
            this.instrumento = instrumento;
        }

        public void Tocar()
        {
            this.instrumento.Mantener();
            this.instrumento.Sonar();
        }
    }
}
