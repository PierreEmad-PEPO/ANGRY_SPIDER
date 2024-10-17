using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "All Resources/Material")]
public class MaterialsSO : ResourceItemSO
{
    public override bool IsStackable => true;

    public override void Use()
    {
        throw new System.NotImplementedException();
    }

    public override void StoreToInventory()
    {
        throw new System.NotImplementedException();
    }

    public override void RemoveFromInventory()
    {
        throw new System.NotImplementedException();
    }
}
