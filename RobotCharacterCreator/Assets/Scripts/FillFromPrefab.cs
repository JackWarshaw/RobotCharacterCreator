using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;
using UnityEngine.UI;

using PartContainers;

public class FillFromPrefab : MonoBehaviour
{

    List<string> AllOrderComponents = new List<string> { "Strong", "Weak", "Chunky", "Smooth", "Slender", "Weird", "Industrial", "Bright", "Simple", "Complex" };

    List<string> AllTypes = new List<string> { "Head", "Legs", "Chest" };

    List<string> AllBrands = new List<string> { "RobCo", "Vitruvian", "NorthStar" };

    [System.Serializable]
    public class RobotPartHolder 
    {
        public PartContainer Head;
        public PartContainer Chest;
        public PartContainer Legs;
    }

    public RobotPartHolder RobotParts;
    PartContainer RobotPart;

    public Image HeadDisplay;
    public Image ChestDisplay;
    public Image LegsDisplay;

    // Start is called before the first frame update
    void Start()
    {
        if (RobotParts.Head != null)
        {
            RobotPart = RobotParts.Head;

            // The following check ensures that part components are correct before being displayed / used
            if (RobotPart.descriptors.All(x => AllOrderComponents.Contains(x)) && AllTypes.Contains(RobotPart.type) && AllBrands.Contains(RobotPart.manufacturer))
            {
                ApplyToButton();
            }
            else
            {
                Debug.Log("Robot Component Typo: Resolve typo in prefab.");
            }
        }
    }

    public void ApplyToButton() 
    {
        if (RobotPart != null) 
        {
            this.GetComponent<Image>().sprite = RobotPart.partSprite;
        }
    }

    public void ApplyPart()
    {
        // will eventually have to update a list / array that stores the order info

        string PartType = RobotPart.type;

        if (PartType == "Head") { HeadDisplay.GetComponent<Image>().sprite = RobotPart.partSprite; }
        else if (PartType == "Chest") { ChestDisplay.GetComponent<Image>().sprite = RobotPart.partSprite; }
        else if (PartType == "Legs") { LegsDisplay.GetComponent<Image>().sprite = RobotPart.partSprite; }
        else { Debug.Log("Invalid Part Type: Resolve typo in prefab."); }

    }

    public void SwitchParts(string partType) 
    {
        if (partType != RobotPart.type) 
        {
            if (partType == "Head")
            {
                RobotPart = RobotParts.Head;
                ApplyToButton();
            }
            else if (partType == "Chest")
            {
                RobotPart = RobotParts.Chest;
                ApplyToButton();
            }
            else if (partType == "Legs")
            {
                RobotPart = RobotParts.Legs;
                ApplyToButton();
            }
            else 
            {
                Debug.Log("Invalid Robot Type: Resolve typo in prefab.");
            }
        }
    }
}
