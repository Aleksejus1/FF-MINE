using UnityEngine;
using System.Collections;
using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
namespace Control {
    public enum Key{
        Up, Left, Down, Right, UpP2, LeftP2, DownP2, RightP2, End
    }
    [XmlRoot("Control")]
    [Serializable]
    public class KeyControl{
        [XmlArray("Controls"), XmlArrayItem("Keys")]
        public static List<KeyCode> keys = new List<KeyCode>();
        public void Initialize(){
            LoadKeys(Path.Combine(Application.persistentDataPath,"keys.xml"));
        }
        public void LoadKeys(string path){
            List<KeyCode> loadedKeys = new List<KeyCode>();
            /*
            var serializer = new XmlSerializer(typeof(List<KeyCode>));
            using (var stream = new FileStream(path, FileMode.Open)){
                loadedKeys = serializer.Deserialize(stream) as List<KeyCode>;
            }
            */
            if (loadedKeys.Count > 0) keys = loadedKeys;
            else loadDefaultKeys();
        }
        public void loadDefaultKeys()
        {
            keys.Add(KeyCode.W);
            keys.Add(KeyCode.A);
            keys.Add(KeyCode.S);
            keys.Add(KeyCode.D);
            keys.Add(KeyCode.UpArrow);
            keys.Add(KeyCode.LeftArrow);
            keys.Add(KeyCode.DownArrow);
            keys.Add(KeyCode.RightArrow);
        }
        public bool Pressed(Key key) {
            return Input.GetKey(keys[(int)key]);
        }
    }
}