using System;
using System.Xml;

namespace Mobius
{
	
	public class SavedLoc
	{
		private string mName;
		private string mKey;
		private float mX;
		private float mY;
		private float mZ;

		public SavedLoc()
		{
			this.mName = "None";
			this.mX = 0;
			this.mY = 0;
			this.mZ = 0;
		}

		public SavedLoc(string name, float x, float y, float z, string key)
		{
			this.mName = name;
			this.mX = x;
			this.mY = y;
			this.mZ = z;
			this.mKey = key;
		}


		public string Name
		{
			get { return this.mName; }
			set { this.mName = value; }
		}

		public float X
		{
			get { return this.mX; }
			set { this.mX = value; }
		}

		public float Y
		{
			get { return this.mY; }
			set { this.mY = value; }
		}

		public float Z
		{
			get { return this.mZ; }
			set { this.mZ = value; }
		}
		
		public string Key
		{
			get { return this.mKey; }
			set { this.mKey = value; }
		}

		public static SavedLoc[] LoadLocations(string filePath)
		{
			System.Collections.ArrayList list;
			list = new System.Collections.ArrayList();

			if (System.IO.File.Exists(filePath))
			{
				XmlDocument doc = new XmlDocument();
				doc.Load(filePath);

				
				XmlNodeList nodes = doc.SelectNodes("//location");

				foreach (XmlNode node in nodes)
				{
					SavedLoc loc = new SavedLoc();
					foreach (XmlNode childNode in node.ChildNodes)
					{
						if (childNode.Name == "name")
						{
							loc.Name = childNode.InnerText;
						}
						else if (childNode.Name == "x")
						{
							loc.X = float.Parse(childNode.InnerText);
						}
						else if (childNode.Name == "y")
						{
							loc.Y = float.Parse(childNode.InnerText);
						}
						else if (childNode.Name == "z")
						{
							loc.Z = float.Parse(childNode.InnerText);
						}
						else if (childNode.Name == "key")
						{
							loc.Key = childNode.InnerText;
						}
					}
					list.Add(loc);
				}
			}
			return (SavedLoc[])list.ToArray(typeof(SavedLoc));
		}

		public static void SaveLocations(string filePath, SavedLoc[] locations)
		{
			System.IO.FileStream stream = System.IO.File.Create(filePath);
			XmlTextWriter xml = new XmlTextWriter(stream, System.Text.Encoding.ASCII);

			xml.Formatting = Formatting.Indented;
			xml.Indentation = 2;
			xml.IndentChar = ' ';
			
			xml.WriteStartDocument(true);

			xml.WriteStartElement("saved");

			foreach(SavedLoc loc in locations)
			{
				xml.WriteStartElement("location");

				xml.WriteStartElement("name");
				xml.WriteString(loc.Name);
				xml.WriteEndElement();

				xml.WriteStartElement("x");
				xml.WriteString(loc.X.ToString());
				xml.WriteEndElement();

				xml.WriteStartElement("y");
				xml.WriteString(loc.Y.ToString());
				xml.WriteEndElement();

				xml.WriteStartElement("z");
				xml.WriteString(loc.Z.ToString());
				xml.WriteEndElement();
				
				xml.WriteStartElement("key");
				xml.WriteString(loc.Key.ToString());
				xml.WriteEndElement();

				xml.WriteEndElement();
			}

			xml.WriteEndElement();
			xml.WriteEndDocument();

			xml.Flush();
			stream.Flush();

			xml.Close();
			stream.Close();

		}
		public static void RemoveLoc(string strXml, string strMember)
		{
			// Open the location xml
			XmlDocument xdMembers = new  XmlDocument(); 
			xdMembers.Load(strXml);
			XmlNodeList xnlList = xdMembers.GetElementsByTagName("location");
			for (int intMember = 0; intMember < xnlList.Count; intMember++)
			{   
				//Find the correct location
				if(xnlList[intMember].FirstChild.InnerXml == strMember)
				{
					XmlElement xeRoot = xdMembers.DocumentElement;
					xeRoot.RemoveChild(xnlList[intMember]);
					//Write the xml
					XmlTextWriter xtwMembers = new XmlTextWriter(strXml, null);
					xtwMembers.Formatting = Formatting.Indented;
					xdMembers.Save(xtwMembers);
					xtwMembers.Close();
					return;
				}
			}
		}

		public static void EditMember(string strXml, string strLocation, string strNewName, string strNewX, string strNewY,string strNewZ)
		{
			// Open the location xml
			XmlDocument xdLocation = new  XmlDocument(); 
			xdLocation.Load(strXml);
			XmlNodeList xnlList = xdLocation.GetElementsByTagName("location");
			for (int intLocation = 0; intLocation < xnlList.Count; intLocation++)
			{   
				//Find the correct location
				if(xnlList[intLocation].FirstChild.InnerXml == strLocation)
				{
					xnlList[intLocation].FirstChild.InnerXml = strNewName;
					xnlList[intLocation].ChildNodes[1].InnerXml = strNewX;
					xnlList[intLocation].ChildNodes[2].InnerXml = strNewY;
					xnlList[intLocation].ChildNodes[3].InnerXml = strNewZ;
					//Write the xml
					XmlTextWriter xtwLocation = new XmlTextWriter(strXml, null);
					xtwLocation.Formatting = Formatting.Indented;
					xdLocation.Save(xtwLocation);
					xtwLocation.Close();
					return;
				}
			}
		}
	}
}
