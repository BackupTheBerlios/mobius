//
//	Author: Devil323
//
//
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
namespace Mobius
{
	public class IniFileManager
	{

		private string myIniFileName="";
		private bool myFileReaded = false;
		private SortedList myFileLines = new SortedList();		
		private SortedList mySectionKeysLines = new SortedList(); 
		private long MaxFileLines =0;
		private long InsertedKeys =0;

		enum iniLineType {empty,comment,section,keyValue};
		
		public IniFileManager(string iniFileName)
		{
			Debug.Assert ( iniFileName != null && iniFileName != "");
			myIniFileName = iniFileName;
			myFileReaded = ReadIniFile();
		}
		public IniFileManager()
		{
			myFileReaded =false;
		}
		
		public string IniFileName
		{
			get { return myIniFileName; }
			set
				{
					myFileReaded = false;
					myIniFileName = value;
				}
		}
		
		private string BuildSectionKeyToHKey(string section,string key) { 
			
			Debug.Assert(section != null && section!= "");
			Debug.Assert(key !=null && key!="" && key.IndexOf("=")<0);
			return (BuildSectionToHKey(section) + key.Trim());
		}
		private string BuildSectionToHKey(string section) { 
			
			Debug.Assert(section != null && section!= "");
			return ("["+ section.Trim()+ "]");
		}
		private string BuildLineToHKey(string lineCount, string extension)
		{
			//To Build the valid index to be sorted by the SortList
			return(  lineCount.PadLeft(10,"0".ToCharArray()[0]) + extension);
		}
		private bool ReadIniFile()
		{

			if (myFileReaded==true) return (true);
			if (!File.Exists(myIniFileName))
			{
				FileStream myNewFile = File.Create (myIniFileName);
				myNewFile.Close();
			}
			string line = "";
			long lineCount =0;
			myFileLines = new SortedList();
			mySectionKeysLines = new SortedList();
			string currentSection="[Default]"; 
			using (StreamReader readFileStream = new StreamReader(myIniFileName) )
			{
				try
				{
					while (readFileStream.Peek() > -1) 
					{
						line = readFileStream.ReadLine().Trim(); 
						lineCount ++ ;
						if (this.GetIniLineType(line)== (int) iniLineType.section)
						{
							currentSection = line;
							mySectionKeysLines.Add(currentSection,BuildLineToHKey(lineCount.ToString(), ".0"));	
						}
						else if (this.GetIniLineType(line)== (int) iniLineType.keyValue)
						{
							mySectionKeysLines.Add(currentSection + GetKeyFromLine(line),BuildLineToHKey(lineCount.ToString(), ".0")); 
						}
						myFileLines.Add(BuildLineToHKey(lineCount.ToString(), ".0"),line);
					}
					MaxFileLines = lineCount;
					myFileReaded=true;
				}
				catch(System.Exception e)
				{
					 throw new System.Exception("Error reading file: " + myIniFileName ,e);
				}
			}
			return (myFileReaded);
		}
		private int GetIniLineType(string lineText)
		{

			int tempIniLineType =0;
			Debug.Assert(lineText != null);
			lineText = lineText.Trim();	// Always the line is trimed
			if ( lineText =="" )
				tempIniLineType = (int) iniLineType.empty; //Why? (int)
			else if (lineText.StartsWith(";"))
				tempIniLineType = (int) iniLineType.comment;
			else if (lineText.StartsWith("[") && lineText.EndsWith("]") )
				tempIniLineType = (int) iniLineType.section;
			else
				tempIniLineType= (int) iniLineType.keyValue;
			Debug.Assert(tempIniLineType>=0 && tempIniLineType<=3 ); 
			return (tempIniLineType);
		}
		private string GetKeyFromLine(string line)
		{

			Debug.Assert (line!= null);
			string[] lineSplitted =line.Split("=".ToCharArray());
			Debug.Assert (lineSplitted.Length>0);
			return(lineSplitted[0]);
		}
		private string GetValueFromLine(string line)
		{

			Debug.Assert (line!= null);
			string[] lineSplitted =line.Split("=".ToCharArray());
			if (lineSplitted.Length>1)
				return(lineSplitted[1]);
			else
				return ("");
		}
		private bool ModifyKeyValue(string section,string key, string keyValue)
		{

			Debug.Assert(ExistsSectionKey(section,key));
			string posLine = mySectionKeysLines[BuildSectionKeyToHKey(section,key)].ToString();
			myFileLines[posLine] = key + "=" + keyValue ;
			return (true);
		}
		private bool InsertKeyValue(string section,string key, string keyValue)
		{
			Debug.Assert(!ExistsSectionKey(section,key));
			InsertedKeys ++ ;
			MaxFileLines ++ ;
			string posLine = mySectionKeysLines[BuildSectionToHKey(section)].ToString();
			mySectionKeysLines.Add( BuildSectionKeyToHKey(section,key) ,BuildLineToHKey(posLine , InsertedKeys.ToString()) );
			myFileLines.Add (BuildLineToHKey(posLine , InsertedKeys.ToString()) ,key + "=" + keyValue );
			return (true);
		}
		private bool InsertSection(string section)
		{

			Debug.Assert(!ExistsSection(section));
			MaxFileLines++;
			mySectionKeysLines.Add( BuildSectionToHKey(section) ,MaxFileLines.ToString() + "." + "0" );
			myFileLines.Add (BuildLineToHKey(MaxFileLines.ToString() , ".0" ),BuildSectionToHKey(section) );
			return (true);
		}
		//Public Methods
		public bool WriteValue(string section,string key, string keyValue)
		{

			Debug.Assert(section != null && section!= "");
			Debug.Assert(key !=null && key!="" && key.IndexOf("=")<0);// Char "=" not permit in key Name
			Debug.Assert(keyValue!=null);
			if (!ReadIniFile())return (false);
			bool isWriteOK=false;
			section = section.Trim();
			key = key.Trim();
			if (ExistsSectionKey(section,key))
			{
				isWriteOK = ModifyKeyValue(section,key,keyValue);
			}
			else if (ExistsSection(section))
			{
				isWriteOK = InsertKeyValue(section,key,keyValue);
			}
			else
			{
				isWriteOK = InsertSection(section);
				if (isWriteOK) isWriteOK = InsertKeyValue(section,key,keyValue);
			}
			Debug.Assert (ExistsSectionKey(section,key)); 
			Debug.Assert (this.ReadValue(section,key,"")==keyValue);
			return (isWriteOK);
		}
		public bool WriteValue(string section,string key, int keyValue)
		{
			Debug.Assert(section != null && section!= "");
			Debug.Assert(key !=null && key!="" && key.IndexOf("=")<0);
			if (!ReadIniFile())return (false);
			return (this.WriteValue(section,key,keyValue.ToString()));
		}
		public string ReadValue(string section,string key, string defaultValue)
		{

			Debug.Assert(section != null && section!= "");
			Debug.Assert(key !=null && key!="" && key.IndexOf("=")<0);
			string retValue = defaultValue;
			try
			{
				if (!ReadIniFile()) return (defaultValue);
				if (!this.ExistsSectionKey(section,key))
					retValue = defaultValue;
				else
					{
					string positionline = mySectionKeysLines[BuildSectionKeyToHKey(section,key)].ToString();
					retValue = GetValueFromLine(myFileLines[positionline].ToString());
					}
			}
			catch (System.Exception e)
				{
					 throw new System.Exception("Error reading file: " + myIniFileName + ";section=" + section +";Key=" + key ,e);
				}
			return (retValue);
		}
		public int ReadValue(string section,string key, int defaultValue)
		{

			Debug.Assert(section != null && section!= "");
			Debug.Assert(key !=null && key!="" && key.IndexOf("=")<0);
			int retValue = defaultValue;	
			try
			{
				if (!ReadIniFile())return (retValue);
				if (!this.ExistsSectionKey(section,key))
					retValue = defaultValue;
				else
					retValue = int.Parse(this.ReadValue(section,key,defaultValue.ToString()),System.Globalization.NumberStyles.Integer);
			}
			catch(System.Exception e)
				{
				throw new System.Exception("Error reading value in file: " + myIniFileName + ";section=" + section +";Key=" + key ,e);
				}
			return (retValue);
		}
		public bool ExistsSectionKey (string section, string key)
		{
	
			Debug.Assert(section != null && section!= "");
			Debug.Assert(key !=null && key!="" && key.IndexOf("=")<0);
			if (!ReadIniFile()) return (false);
			return (mySectionKeysLines.Contains(BuildSectionKeyToHKey(section,key)));
		}
		public bool EraseSectionKey(string section,string key)
		{
			Debug.Assert(section != null && section!= "");
			Debug.Assert(key !=null && key!="" && key.IndexOf("=")<0);//char = not permit in key
			try{
				if (!ReadIniFile())return (false);
				if (!ExistsSectionKey(section,key)) return (true); //If [section]+key not exists , nothing to do !
				string positionLine = mySectionKeysLines[BuildSectionKeyToHKey(section,key)].ToString();
				myFileLines.Remove(positionLine);
				mySectionKeysLines.Remove(BuildSectionKeyToHKey(section,key));
				return(true);
			}
			catch(System.Exception e)
			{
				throw new System.Exception("Error deleting key in file: " + myIniFileName + ";section=" + section +";Key=" + key ,e);
			}
		}

		public bool ExistsSection (string section)
		{
			Debug.Assert(section != null && section!= "");
			try	{
				if (!ReadIniFile())return (false);
				return (mySectionKeysLines.Contains( BuildSectionToHKey( section.Trim()) ));
			}
			catch (System.Exception e){
				throw new System.Exception("Error searching section in file: " + myIniFileName + ";section=" + section  ,e);
			}
		}
		public bool EraseSection (string section)
		{
			Debug.Assert(section != null && section!= "");
			try	{
				if (!ReadIniFile())return (false);
				if (!ExistsSection(section)) return (true); //If section not exists, nothing to do !
				int indexOfSection = myFileLines.IndexOfValue(BuildSectionToHKey(section));
				string line;
				mySectionKeysLines.Remove(BuildSectionToHKey(section));
				myFileLines.RemoveAt(indexOfSection);
				while  (indexOfSection < myFileLines.Count && GetIniLineType(myFileLines.GetByIndex(indexOfSection).ToString())!= (int) iniLineType.section )
				{
					line = myFileLines.GetByIndex(indexOfSection).ToString();
					if (GetIniLineType(line)== (int) iniLineType.keyValue)
						EraseSectionKey(section,GetKeyFromLine(line));
					else
						myFileLines.RemoveAt(indexOfSection);
				}

				return (true);
			}
			catch (System.Exception e)	{
				throw new System.Exception("Error deleting section in file: " + myIniFileName + ";section=" + section  ,e);
			}
		}
		public bool FlushToDisk()
		{
			try	{
				using (StreamWriter iniFileWriter = new StreamWriter(myIniFileName)){
					for (int i = 0; i<myFileLines.Count ; i++)
						iniFileWriter.WriteLine(myFileLines.GetByIndex(i));
				}
			}
			catch (System.Exception e){
				throw new System.Exception("Error saving file: " + myIniFileName,e);
			}
			return (true);
		}
	}
	
}