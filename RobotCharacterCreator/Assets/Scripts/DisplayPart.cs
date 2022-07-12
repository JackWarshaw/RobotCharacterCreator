using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using static SpriteDictClass;

public class DisplayPart : MonoBehaviour
{ 
    public Image HeadDisplay;
    public Image ChestDisplay;
    public Image LegsDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyPart()
    {
        Sprite DesiredSprite = this.GetComponent<Image>().sprite;
        string ImageName = DesiredSprite.name;
        string PartType = SpriteDict[ImageName][0];
        
        if (PartType == "Head"){HeadDisplay.GetComponent<Image>().sprite = DesiredSprite;}
        else if (PartType == "Chest"){ChestDisplay.GetComponent<Image>().sprite = DesiredSprite;}
        else if (PartType == "Legs"){LegsDisplay.GetComponent<Image>().sprite = DesiredSprite;}
        else {Debug.Log("Invalid Part Type");}

    }
}
