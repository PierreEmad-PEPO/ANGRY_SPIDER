using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllResources : MonoBehaviour
{
    public static AllResources Instance { get; private set; }

    // add all resources' instances to get from

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
