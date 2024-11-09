using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitres : MonoBehaviour
{
    public Image fone;
    public Text masage;
    private float timer;
    public static Subtitres rid { get; set; }
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

    public void Ontitre(string mas)
    {
        fone.enabled = true;
        masage.text += mas;
        timer = Time.time + 3.0f;
    }
    private void FixedUpdate()
    {
        if (timer <= Time.time) 
        {
            fone.enabled = false;
            masage.text = "";
        }
    }
}
