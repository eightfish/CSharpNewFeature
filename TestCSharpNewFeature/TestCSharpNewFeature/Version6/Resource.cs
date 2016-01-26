using System;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TestCSharpNewFeature
{
    internal class Resource
    {
        public bool IsOpened { get; } = true;
        private static Resource Singleton;

        internal static Task<Resource> OpenAsync()
        {
            return Task.Run<Resource>(() => 
            {
                Resource.Singleton = new Resource();
                return Resource.Singleton;
            });
        }

        internal static Task LogAsync(Resource res, ResourceException e)
        {
            //nothing to do yet
            return null;
        }

        internal Task CloseAsync()
        {
            return Task.Run(() => { Resource.Singleton = null; });
        }
    }

    [Serializable]
    internal class ResourceException : Exception
    {
        public ResourceException()
        {
        }

        public ResourceException(string message) : base(message)
        {
        }

        public ResourceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ResourceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}