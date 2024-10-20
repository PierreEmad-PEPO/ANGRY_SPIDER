using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    Dictionary<ResourceItemSO, int> resources = new Dictionary<ResourceItemSO, int>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddToInventory(ResourceItemSO _item, int _amount)
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

    public void RemoveFromInventory(ResourceItemSO _item, int _amount) 
    {
        if (resources.ContainsKey(_item))
        {
            resources[_item] -= _amount;
        }
    }
}
