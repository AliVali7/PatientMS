using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDB.Common
{
	internal class Response<T> : Response, IResponse<T>
	{
        public T Data { get; set; }
		public List<CustomValidationError> ValidationErrors { get; set; }
        public Response(ResponseType responseType, string message) : base(responseType,message)
        {
           
        }

		public Response(ResponseType responseType, T data) : base(responseType)
		{
			Data = data;
		}

		public Response(ResponseType responseType, T data, List<CustomValidationError> validationErrors) : base(responseType)
		{
			Data = data;
			ValidationErrors = validationErrors;
		}
	}
}
