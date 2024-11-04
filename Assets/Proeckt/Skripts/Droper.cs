using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Droper : MonoBehaviour
{
    public static event Action<Transform> onFool;
    public GameObject tnt;
    public Rigidbody rb;
    private bool active = true;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Navigation>().Nokout();
            if (active)
            {
                active = false;
                Destroy(gameObject);
                Instantiate(tnt, transform.position, transform.rotation);
            }
        }
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "TNT")
        {
            if (active)
            {
                active = false;
                GameObject target = Instantiate(tnt);
                target.transform.position = transform.position;
                target.transform.rotation = transform.rotation;
                onFool.Invoke(target.transform);
                Destroy(gameObject);

            }
        }
    }
}
