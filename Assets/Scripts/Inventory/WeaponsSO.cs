using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "All Resources/Weapon")]
public class WeaponsSO : ResourceItemSO
{
    public override bool IsStackable => false;

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
