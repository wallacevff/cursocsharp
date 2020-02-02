using System;

namespace Aula145ExercicioProposto_Excessoes_.Entities.Exceptions {
    class DomainException  : ApplicationException{
        public DomainException(string message) : base(message) {

        }
    }
}
