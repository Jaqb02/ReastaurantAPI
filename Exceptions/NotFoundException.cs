using System;

namespace ReastaurantAPI.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string Message) : base(Message)
        { 

        }
    }
}
