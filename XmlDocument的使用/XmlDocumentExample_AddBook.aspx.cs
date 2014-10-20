#region

using System;
using System.IO;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlDocument的使用
{
	public partial class XmlDocumentExample_AddBook : Page
	{
		protected void btnSave_Click(object sender, EventArgs e)
		{
			string xmlPath = Server.MapPath("NewBooks.xml");
			XmlDocument doc = new XmlDocument();
			//Check if the file already exists or not
			if (File.Exists(xmlPath))
			{
				doc.Load(xmlPath);
				XmlNode bookNode = CreateBookNode(doc);
				//Get reference to the book node and append the book node to it
				XmlNode bookStoreNode = doc.SelectSingleNode("bookstore");
				bookStoreNode.AppendChild(bookNode);
				lblResult.Text = "XML Document has been successfully updated";
			}
			else
			{
				XmlNode declarationNode = doc.CreateXmlDeclaration("1.0", "", "");
				doc.AppendChild(declarationNode);
				XmlNode comment = doc.CreateComment("This file represents a fragment of a book store inventory database");
				doc.AppendChild(comment);
				XmlNode bookstoreNode = doc.CreateElement("bookstore");
				XmlNode bookNode = CreateBookNode(doc);
				//Append the book node to the bookstore node            
				bookstoreNode.AppendChild(bookNode);
				//Append the bookstore node to the document
				doc.AppendChild(bookstoreNode);
				lblResult.Text = "XML Document has been successfully created";
			}
			doc.Save(xmlPath);
		}

		private XmlNode CreateBookNode(XmlDocument doc)
		{
			XmlNode bookNode = doc.CreateElement("book");
			//Add the genre attribute to the book node
			XmlAttribute genreAttribute = doc.CreateAttribute("genre");
			genreAttribute.Value = txtGenre.Text;
			bookNode.Attributes.Append(genreAttribute);

			//Add all the children of the book node            
			XmlNode titleNode = doc.CreateElement("title");
			titleNode.InnerText = txtTitle.Text;
			bookNode.AppendChild(titleNode);

			//Create the author node and its children
			XmlNode authorNode = doc.CreateElement("author");
			XmlNode firstNameNode = doc.CreateElement("first-name");
			firstNameNode.InnerText = txtFirstName.Text;
			authorNode.AppendChild(firstNameNode);

			XmlNode lastNameNode = doc.CreateElement("last-name");
			lastNameNode.InnerText = txtLastName.Text;
			authorNode.AppendChild(lastNameNode);

			bookNode.AppendChild(authorNode);

			XmlNode priceNode = doc.CreateElement("price");
			priceNode.InnerText = txtPrice.Text;
			bookNode.AppendChild(priceNode);

			return bookNode;
		}
	}
}