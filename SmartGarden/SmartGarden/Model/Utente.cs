using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    class Utente : IUtente
    {
        private bool _isValid;

        public Utente()
        {
            ;
        }

        public bool Login(string password)
        {
            /* using (PrincipalContext pc = new PrincipalContext(ContextType.Machine))
             {
                 _isValid = pc.ValidateCredentials(Environment.UserName, password);
             }
             return _isValid;*/
            return true;
        }
    }

    
}
