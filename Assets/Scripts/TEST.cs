using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InventoryManager.instance.AddToInventory(AllResources.Pizza, 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
