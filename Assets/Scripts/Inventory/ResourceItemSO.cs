using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ResourceItemSO : ScriptableObject
{
    [SerializeField]
    protected Sprite icon;

    public abstract bool IsStackable { get; }

    public abstract void Use();
    public abstract void StoreToInventory();
    public abstract void RemoveFromInventory();

}
