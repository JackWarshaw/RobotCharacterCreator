using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PartTypeSwitch : MonoBehaviour
{
    public Transform gridButtons;

    public void SwitchTypes(string partType) 
    {
        foreach (Transform child in gridButtons) 
        {
            if (child.GetComponent<FillFromPrefab>().enabled == true) 
            {
                child.GetComponent<FillFromPrefab>().SwitchParts(partType);
            }
        }
    }
}
