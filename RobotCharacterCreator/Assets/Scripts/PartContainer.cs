using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PartContainer", menuName = "Parts" )]

public class PartContainer : ScriptableObject
{
    [SerializeField] int id;
    [SerializeField] string name;
    [SerializeField] string manufacturer;
    [SerializeField] string type;
    [SerializeField] string[] descriptors;
    [SerializeField] Sprite partSprite; 

    public int ID { get { return id; } set { id = value; } }

    public string Name { get { return name; } set { name = value; } }

    public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }

    public string Type { get { return type; } set { type = value; } }

    public string[] Descriptors { get { return descriptors; } set { descriptors = value; } }
}
