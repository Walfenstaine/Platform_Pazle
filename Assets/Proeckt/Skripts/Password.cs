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

    void Start()

    {
        name = "7054";
    }

    void Update()

    {
        if(str == "")
        {
            txt.text = "������� ������";
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
            SoundPlayer.regit.Play(clip , 1);
        }
        else
        {
            SoundPlayer.regit.Play(sound , 1);
        }
    }

}
