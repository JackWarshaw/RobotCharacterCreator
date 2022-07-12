using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

using static SpriteDictClass;
//using static ReRollParts;

public class GenerateDesiredPart : MonoBehaviour
{
    public Text WantedHead;
    public Text WantedChest;
    public Text WantedLegs;
    public Image GridParent;

    private List<string> prevOrder = new List<string> { };

    // Start is called before the first frame update
    void Start()
    {
        NewOrder();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void NewOrder() 
    {
        List<string> AllOrderComponents = new List<string> { "Strong", "Weak", "Chunky", "Smooth", "Slender", "Weird", "Industrial", "Bright", "Simple", "Complex" };
        
        List<string> OrderComponents = AllOrderComponents.Except(prevOrder).ToList();

        prevOrder = new List<string>{ };

        string[] newOrder = new string[3];

        Random Rand = new Random();

        for (int i = 0; i < 3; i++) 
        {
            int randNum = OrderComponents.Count;

            newOrder[i] = OrderComponents[Rand.Next(0, randNum)];

            OrderComponents.Remove(newOrder[i]);

            prevOrder.Add(newOrder[i]);
        }

        WantedHead.text = newOrder[0];
        WantedChest.text = newOrder[1];
        WantedLegs.text = newOrder[2];

        RollNewParts();

    }


    
    public void RollNewParts()
    {
        Random Rand = new Random();

        Button[] GridChildren = GridParent.GetComponentsInChildren<Button>();

        foreach (Button Part in GridChildren)
        {

            int r = Rand.Next(SpriteDictKeys.Count);
            string hold = "PartPictures\\" + SpriteDictKeys[r];
            var randomSprite = Resources.Load<Sprite>(hold);
            Part.GetComponent<Image>().sprite = randomSprite;
        }
    }
    
}

