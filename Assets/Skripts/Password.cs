using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Password : MonoBehaviour
{
    public int i;
    public string str;
    public Text txt;
    public AudioSource sors;
    public AudioClip clip , sound;

    void Start()

    {
        i = Random.Range(1000 , 9999);
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
        str += code;
    }

    public void Delete()

    {
        str = "";
    }

    public void Check()

    {
        if(int.Parse(str) == i)
        {
            sors.PlayOneShot(clip);
        }
        else
        {
            sors.PlayOneShot(sound);
        }
    }

}
