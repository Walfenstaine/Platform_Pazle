using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Exit : MonoBehaviour
{
    public int nextIndex;
    public string scene;
    public Data position;
    public enum Rezgim {test, worck}
    public Rezgim rezgim;
    private void Awake()
    {
        if (rezgim == Rezgim.test)
        {
            position.position.Add(transform.position + transform.forward*3 + transform.up);
            position.rotation.Add(transform.rotation);
        }
    }
    public void OnTarget() 
    {
        rezgim = Rezgim.worck;
        position.starter = true;
        position.index = nextIndex;
        SceneManager.LoadScene(scene);
    }

}
