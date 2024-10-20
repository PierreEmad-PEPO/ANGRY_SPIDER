using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ResourceItemSO : ScriptableObject
{
    public Sprite icon;
    

    public abstract bool IsStackable { get; }

}
