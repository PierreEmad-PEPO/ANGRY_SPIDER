using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    Dictionary<AllResources, int> resources = new Dictionary<AllResources, int>();
    public static InventoryManager instance;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddToInventory(AllResources _item, int _amount)
    {
        if (resources.ContainsKey(_item))
        {
            resources[_item] += _amount;
        }
        else
        {
            resources.Add(_item, _amount);
        }

        PrintInventory();
    }

    public void RemoveFromInventory(AllResources _item, int _amount) 
    {
        if (resources.ContainsKey(_item))
        {
            resources[_item] -= _amount;
        }

        PrintInventory();
    }

    public void PrintInventory()
    {
        foreach (var _item in resources)
        {
            Debug.Log(_item.Key.GetType().Name + " " + _item.Value);
        }
    }
}
