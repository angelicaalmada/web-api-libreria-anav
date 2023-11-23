using System;
namespace Libreria_anav.Data.Exceptions
{
    public class PublisherNameException : Exception
    {
        public string PublisherName { get; set; }

        public PublisherNameException() 
        {

        }

        public PublisherNameException(string messaje) : base(messaje)
        {

        }
        public PublisherNameException(string messaje, Exception inner) : base(messaje, inner)
        {
           
        }
        public PublisherNameException(string messaje, string publisherName) : this(messaje)
        {
            PublisherName = publisherName;
        }

    }
}
