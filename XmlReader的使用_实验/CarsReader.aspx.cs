#region

using System;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlReader的使用_实验_VS2012
{
	public partial class CarsReader : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string filePath = Server.MapPath("Cars.xml");

			try
			{
				XmlReader reader = XmlReader.Create(filePath);

				while (reader.Read())
				{
					Response.Write(String.Format("<p>【NodeType: {0}】，【NodeName: {1}】，【NodeValue: {2}】</p>", reader.NodeType,
						reader.Name, reader.Value));
				}

				reader.Close();
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
		}
	}
}