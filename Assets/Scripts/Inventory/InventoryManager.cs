using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    Dictionary<ResourceItem, int> resources = new Dictionary<ResourceItem, int>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddToInventory(ResourceItem _item, int _amount)
    {
        if (resources.ContainsKey(_item))
        {
            resources[_item] += _amount;
        }
        else
        {
            resources.Add(_item, _amount);
        }
    }

    public void RemoveFromInventory(ResourceItem _item, int _amount) 
    {
        if (resources.ContainsKey(_item))
        {
            resources[_item] -= _amount;
        }
    }
}
