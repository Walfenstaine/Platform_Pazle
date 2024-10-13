using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Password : MonoBehaviour
{
    public string name;
    public string str;
    public Text txt;
    public AudioSource sors;
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
        if(str.Length < 4)
        {
            str += code;
        }
    }

    public void Delete()

    {
        if(str != "")
        {
            str = "";
            sors.PlayOneShot(radio);    
        }
    }

    public void Check() 

    {
        if(str == name)
        {
            sors.PlayOneShot(clip);
        }
        else
        {
            sors.PlayOneShot(sound);
        }
    }

}
