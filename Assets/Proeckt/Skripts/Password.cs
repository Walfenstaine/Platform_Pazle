using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Password : MonoBehaviour
{
    public string name;
    public string str;
    public Text txt;
    public AudioClip clip , sound , radio;

    void Start()

    {
        name = "7054";
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
        else 
        {
            str = "";
        }
    }

    public void Delete()

    {
        if(str != "")
        {
            str = "";
            SoundPlayer.regit.Play(radio,1);    
        }
    }

    public void Check() 

    {
        if(str == name)
        {
            SoundPlayer.regit.Play(clip,1);
        }
        else
        {
            SoundPlayer.regit.Play(sound,1);
        }
    }

}
