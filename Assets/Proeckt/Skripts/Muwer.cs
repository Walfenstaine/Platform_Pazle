using UnityEngine;
using System.Collections;

public class Muwer : MonoBehaviour {
    public Rigidbody rb;
	public Vector3 muve;
	public Vector2 rut;
	public float sensitivity = 1.1f;
	public Transform cam;
	public float minimumY = -60F;
	public float maximumY = 60F;
	public float speed = 6.0F;
	public float jumpforse = 10;
	public Animator anim;
	float rotationY = 0F;
	public bool grunded;
    public static Muwer rid { get; set; }
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


    private void OnTriggerEnter(Collider other)
    {
		if (other.tag == "Grund"|| other.tag == "Platform") 
		{
            transform.parent = other.transform;
            grunded = true;
            muve.y = 0;
        }
		
    }
    private void OnTriggerExit(Collider other)
    {
		if (other.tag == "Grund" || other.tag == "Platform")
		{
			grunded = false;
            anim.SetTrigger("Jump");
            transform.parent = null;
        }
    }
	public void Jump() 
	{
        muve.y = jumpforse;
	}

    void Update() {
		if (cam != null) {
			float rotationX = transform.localEulerAngles.y + rut.x * sensitivity;
            rotationY += rut.y * sensitivity;
            rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);

			cam.transform.localEulerAngles = new Vector3(-rotationY, 0, 0);
			transform.localEulerAngles = new Vector3(0, rotationX, 0);
		}
        if (!grunded) 
        {
            muve.y -= 9.8f * Time.deltaTime;
        }
	}
    private void FixedUpdate()
    {
        Vector3 nap = transform.TransformDirection(muve);
		anim.SetFloat("Speed", rb.velocity.magnitude/speed*5);
        rb.AddForce(nap * speed);
        if (muve.magnitude > 0)
		{
			anim.SetBool("Walck", true);
		}
		else 
		{
            anim.SetBool("Walck", false);
        }
    }
}
