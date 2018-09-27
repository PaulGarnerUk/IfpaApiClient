using System;
using System.Collections.Generic;
using System.Text;

namespace Ifpa.ApiClient.BaseClasses
{
	/// <summary>
	/// An error
	/// </summary>
	public class ErrorModel
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public ErrorModel(string message)
		{
			Message = message;
		}

		/// <summary>
		/// A more detailed error message.
		/// </summary>		
		public string Message { get; set; }
	}
}
