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
    public void Extsept(int set)
    {
        if (keys.Count > 0) 
        {
            if (keys[0] == set)
            {
                if (keys.Count > 1)
                {
                    keys.RemoveAt(0);
                    CameraUp.rid.AndDemo();
                }
                else 
                {
                    Interface.rid.Sum(2, true, 0);
                }
            }
            else 
            {
                Interface.rid.Sum(3, true, 0);
            }
        }
    }
}
