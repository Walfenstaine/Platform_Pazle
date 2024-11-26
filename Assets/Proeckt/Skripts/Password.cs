using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEditor.Callbacks;
using System;

public class Password : MonoBehaviour
{
    public string name;
    public string str;
    public Text txt;
    public AudioClip clip , sound , radio;
    public static event Action<int> onOpoen;
    public static Password rid { get; set; }
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
    public void Remain(int remain) 
    {
        name = "" + remain;
    }

    void Update()

    {
        if(str == "")
        {
            txt.text = "¬ведите пароль";
        }
        else
        {
            txt.text = str;
        }
    }

    public void Button(int code)

    {
        if (str.Length < 4)
        {
            str += code;
        }     
    }

    public void Delete()

    {
        if(str != "")
        {
            str = "";
            SoundPlayer.regit.Play(radio , 1);    
        }
    }

    public void Check() 

    {
        if(str == name)
        {
            onOpoen.Invoke(int.Parse(str));
            SoundPlayer.regit.Play(clip , 1);
        }
        else
        {
            SoundPlayer.regit.Play(sound , 1);
        }
    }

}
