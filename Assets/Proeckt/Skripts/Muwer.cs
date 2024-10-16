using UnityEngine;
using System.Collections;

public class Muwer : MonoBehaviour {
	public Vector3 muve;
	public Vector2 rut;
	public float sensitivity = 1.1f;
	public Transform cam;
	public float minimumY = -60F;
	public float maximumY = 60F;
	public float speed = 6.0F;
	public float jumpforse = 10;
	public float gravity = 20.0F;
	public Animator anim;
	private Vector3 moveDirection = Vector3.zero;
	float rotationY = 0F;
	private CharacterController controller;
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
    void Start () {
		controller = GetComponent<CharacterController>();
	}

    private void OnTriggerEnter(Collider other)
    {
		if (other.tag == "Grund") 
		{
            grunded = true;
			transform.parent = other.transform;
        }
		
    }
    private void OnTriggerExit(Collider other)
    {
		if (other.tag == "Grund")
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

		if (grunded) {
			moveDirection = muve;
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;

		} else {
			moveDirection.y -= gravity * Time.deltaTime;
			if (controller.velocity.y <= 0) 
			{
                muve.y = 0;
            }
		}

		controller.Move(moveDirection * Time.deltaTime);
	}
    private void FixedUpdate()
    {
		anim.SetFloat("Speed", controller.velocity.magnitude/speed);
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
