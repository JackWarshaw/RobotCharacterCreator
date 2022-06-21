using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class GenerateDesiredPart : MonoBehaviour
{
    public Button SubmitButton;
    public Text WantedHead;
    public Text WantedChest;
    public Text WantedLegs;
    public Image GridParent;

    // Start is called before the first frame update
    void Start()
    {
        SubmitButton.onClick.AddListener(NewOrder);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NewOrder()
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

    void RollNewParts()
    {
        Random Rand = new Random();

        /* 
        string[,] SpriteArray = new string[,]
        {
            {"1221","Head"},
            {"1222", "Chest"},
            {"1223", "Legs"}
        };
        */

        List<string> OnlySpriteString = new List<string>()
        {
            "1221","1222","1223"
        };


        Button[] GridChildren = GridParent.GetComponentsInChildren<Button>();
    
        foreach (Button Part in GridChildren)
        {
            int r = Rand.Next(OnlySpriteString.Count);
            var randomSprite = Resources.Load<Sprite>("PartPictures\\" + OnlySpriteString[r]);
            Debug.Log(randomSprite);
            Part.GetComponent<Image>().sprite = randomSprite;
        }


    }
}

