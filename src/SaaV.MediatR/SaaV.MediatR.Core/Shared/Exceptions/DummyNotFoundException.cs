using System.Runtime.Serialization;

namespace SaaV.MediatR.Core.Shared.Exceptions
{
    [Serializable]
    public class DummyNotFoundException : Exception
    {
        public int Id { get; private set; }

        public DummyNotFoundException(int id) : base($"Dummy[{id}] not found")
        {
            Id = id;
        }

        protected DummyNotFoundException(SerializationInfo serializationIintnfo, StreamingContext streamingContext) : base(serializationIintnfo, streamingContext)
        {
        }
    }
}
