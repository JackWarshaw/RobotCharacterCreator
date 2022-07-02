using System.Collections;
using System.Collections.Generic;
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


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewOrder()
    {
        string[,] PartArray = new string[,] 
        {
            {"Small", "Medium", "Large"},
            {"Green", "Red", "Blue"},
            {"Polka-dotted", "Striped", "Starred"},    
        };

        string[] NewParts = new string[3];
        
        Random Rand = new Random();
        for (int i = 0; i < 3; i++) // 3 is the number of parts to generate
        {  
            
            for (int j = 0; j < PartArray.GetLength(0); j++)
            {
                NewParts[i] = NewParts[i] + PartArray[j,Rand.Next(0,PartArray.GetLength(0))] + ' ';
            }
           
        }
        
        WantedHead.text = NewParts[0];
        WantedChest.text = NewParts[1];
        WantedLegs.text = NewParts[2];


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

