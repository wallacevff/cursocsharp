using System;

namespace Aula144ExcessoesPersonalizadas.Entities.Exceptions {
    class DomainException : ApplicationException {
        public DomainException(string message) : base(message) {

        }
    }
}
