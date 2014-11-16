namespace WebService的使用
{
	public class Address
	{
		public string Street { get; set; }
		public string City { get; set; }

		public string Country { get; set; }
		public int Zip { get; set; }

		public Address()
		{
			
		}

		public Address(string street, string city, string country, int zip)
		{
			Street = street;
			City = city;
			Country = country;
			Zip = zip;
		}
	}
}
