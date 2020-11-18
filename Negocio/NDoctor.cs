using System.Data;
using System.Runtime.Remoting.Messaging;
using Datos;
using Entidades;

namespace Negocio
{
    public class NDoctor
    {
        private DDoctor _dDoctor = new DDoctor();

        public DataTable Log_in(EDoctor eDoctor)
        {
            if (eDoctor.DNI.Length != 8)
            {
                throw errors.Error.DNIInvalid;
            } 
            return _dDoctor.LogIn(eDoctor);
        }
    }
}