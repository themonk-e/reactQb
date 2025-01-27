using Newtonsoft.Json;
using System.Collections.Generic;

namespace reactQb
{

	public class FileFormatManager
	{
		public int FFMId { get; set; }
		public List<Field> Fields { get; set; }
	}

	public class Field
	{
		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; } = "text";


	}

}
