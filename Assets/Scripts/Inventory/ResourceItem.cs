using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ResourceItem
{
    protected Sprite icon;

    protected abstract void StoreToInventory();
    protected abstract void RemoveFromInventory();

}
