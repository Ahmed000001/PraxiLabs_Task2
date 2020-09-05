using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;

public class PlayersSerializer : MonoBehaviour
{
    public static PlayersSerializer instance=null;
    public List<string> PlayersIDs;
    public string path ;
    public string filename ;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            
        }
        
        if(string.IsNullOrEmpty( path))
              path = Application.dataPath;
        if(string.IsNullOrEmpty(filename))
              filename = "PlayersIDs.xml";
        ReadPlayersXmlFile(path, filename);
    }

    void ReadPlayersXmlFile(string path,string filename)
    {
        var cpath = Path.Combine(path, filename);
        XmlSerializer xmlSerializer = new XmlSerializer(PlayersIDs.GetType());
        StreamReader streamReader = new StreamReader(cpath);
       PlayersIDs=(List<string>) xmlSerializer.Deserialize(streamReader);
        streamReader.Close();

    }
     
 
}
