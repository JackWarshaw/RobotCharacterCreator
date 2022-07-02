using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteDictClass : MonoBehaviour
{

    
    public static Dictionary<string,string[]> SpriteDict = new Dictionary<string,string[]>()
    {
        {"1121",new string[]{"Head", "Red"}},
        {"1122", new string[]{"Chest", "Blue"}},
        {"1123", new string[]{"Legs", "Green"}}
    };

    public static List<string> SpriteDictKeys =  new List<string>(SpriteDict.Keys);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
