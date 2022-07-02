using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

using static SpriteDictClass;

public class ReRollParts : MonoBehaviour
{

    public Image GridParent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
