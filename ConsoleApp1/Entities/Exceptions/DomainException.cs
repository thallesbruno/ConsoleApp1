using System;

namespace CSharp_TryCatch.Entities.Exceptions{
    class DomainException : ApplicationException{
        public DomainException(string message) : base(message){

        }
    }
}