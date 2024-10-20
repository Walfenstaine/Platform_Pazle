using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Password : MonoBehaviour
{
    public string name;
    public string str;
    public Text txt;
    public AudioClip clip , sound , radio;
    public UnityEvent sumer;
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
    public void Remain(int passvord) 
    {
        name = "" + passvord;
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
            sumer.Invoke();
            SoundPlayer.regit.Play(clip , 1);
        }
        else
        {
            SoundPlayer.regit.Play(sound , 1);
        }
    }

}
