using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using static SetText;
public class Dor : MonoBehaviour
{
    [SerializeField] private Language language;
    public int password;
    public bool closed;
    public Animator anim;

    public void Opened(int number) 
    {
        if (number == password) 
        {
            closed = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!closed)
            {
                anim.SetBool("Open", true);
            }
            else 
            {
                if (YandexGame.EnvironmentData.language == "ru")
                {
                    Subtitres.rid.Ontitre(language.ru);
                }
                else
                {
                    if (YandexGame.EnvironmentData.language == "en")
                    {
                        Subtitres.rid.Ontitre(language.en);
                    }
                    if (YandexGame.EnvironmentData.language == "tr")
                    {
                        Subtitres.rid.Ontitre(language.tr);
                    }

                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("Open", false);
        }
    }
}
