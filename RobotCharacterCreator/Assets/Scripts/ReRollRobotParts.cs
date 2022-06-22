using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class ReRollRobotParts : MonoBehaviour
{
    public Button ReRoll;
    public Image GridParent; // This is what the Grid Layout of images is under


    // Start is called before the first frame update
    void Start()
    {
        ReRoll.onClick.AddListener(RollNewParts);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RollNewParts()
    {
        Random Rand = new Random();

        string cd = Directory.GetCurrentDirectory();
        string SpriteDirectory = cd + "\\Assets\\Resources\\PartPictures\\";
        string[] SpriteArray = Directory.GetFiles(SpriteDirectory);
       
        string[] PrunedSpriteArray = SpriteArray.Where(x => Path.GetExtension(x) != ".meta").ToArray(); 
        
        var OnlySpriteString = new List<string>();


        foreach(string Path in PrunedSpriteArray)
        {
            string[] splitString = Path.Split('\\');
            string[] SpriteNameAndExtension = splitString[splitString.GetLength(0) - 1].Split('.');

            OnlySpriteString.Add(SpriteNameAndExtension[0]);
        }

        Button[] GridChildren = GridParent.GetComponentsInChildren<Button>();

        foreach (Button Part in GridChildren)
        {

            int r = Rand.Next(OnlySpriteString.Count);
            var randomSprite = Resources.Load<Sprite>("PartPictures\\" + OnlySpriteString[r]);
            Part.GetComponent<Image>().sprite = randomSprite;
        }


    }
}
