using System;

namespace Generic
{
	class GenericProgram
	{
		static void Main(string[] args)
		{
			DataStore<string> strStore = new DataStore<string>();
			//creating generic class instance.

			strStore.Data = "Hello World!";
			
			Console.WriteLine(strStore.Data);

			DataStore<int> intStore = new DataStore<int>();
			intStore.Data = 100;
			
			Console.WriteLine(intStore.Data);

			KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
			kvp1.Key = 100;
			kvp1.Value = "Hundred";
			Console.WriteLine(kvp1.Key + ", " + kvp1.Value);


			KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
			kvp2.Key = "IT";
			kvp2.Value = "Information Technology";
			Console.WriteLine(kvp2.Key + ", " + kvp2.Value);
		}
	}
	//Generic class declaration.
	class DataStore<T>
	{
		public T Data { get; set; }// fiels of generic class
	}
	//gereric class declaration with multiple parameters.
	class KeyValuePair<TKey, TValue>
	{
		public TKey Key { get; set; }
		public TValue Value { get; set; }
	}
}