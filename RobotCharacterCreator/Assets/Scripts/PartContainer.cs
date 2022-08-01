using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PartContainers
{
    [CreateAssetMenu(fileName = "PartContainer", menuName = "Parts")]

    public class PartContainer : ScriptableObject
    {
        [SerializeField] public int id;
        [SerializeField] public string partName;
        [SerializeField] public string manufacturer;
        [SerializeField] public string type;
        [SerializeField] public string[] descriptors;
        [SerializeField] public Sprite partSprite;

        public int ID { get { return id; } set { id = value; } }

        public string PartName { get { return partName; } set { partName = value; } }

        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }

        public string Type { get { return type; } set { type = value; } }

        public string[] Descriptors { get { return descriptors; } set { descriptors = value; } }
    }
}