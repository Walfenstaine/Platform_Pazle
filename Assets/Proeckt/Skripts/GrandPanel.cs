using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandPanel : MonoBehaviour
{
    public List<int> keys;
    public static GrandPanel rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }

    public void Ensept(int set) 
    {
        keys.Add(set);
    }
}
