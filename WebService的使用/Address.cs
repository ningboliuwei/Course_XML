namespace WebService的使用
{
	public class Address
	{
		#region Fields

		public string City;

		public string Country;

		public string Street;

		public int ZIP;

		#endregion

		#region Constructors and Destructors

		public Address()
		{
		}

		public Address(string _Street, string _City, string _Country, int _ZIP)
		{
			Street = _Street;
			City = _City;
			ZIP = _ZIP;
			Country = _Country;
		}

		#endregion
	}
}