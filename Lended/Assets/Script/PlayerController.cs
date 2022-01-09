using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using SWNetwork;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public Camera cam;
    public Joystick joystick;
    public SceneChanger sceneChanger;
    public float movementSpeed;
    public Rigidbody2D rb;
    float mx;
    public float jumpForce = 20f;
    private float jumpCooldown;
    public LayerMask groundLayers;
    public bool isOnGround = true;
    private float prevHorizontal;
    private bool direction;
    NetworkID networkID;

    float hInput = 0;

    private void Start()
    {
        direction = true;
        networkID = GetComponent<NetworkID>();
    }

    private void Update()
    {
        float movement = joystick.Horizontal;
        if(joystick.Horizontal != 0)
        {
            if (joystick.Horizontal < 0.05 && joystick.Horizontal > -0.05)
            {
                movement = 0.0f;
            }
            else
            {
                movement = joystick.Horizontal;
            }
            
        }
		Move(movement);
        /*if (networkID.IsMine) { 
            Move(Input.GetAxisRaw("Horizontal"));
			if (Input.GetButtonDown("Jump") && isOnGround) {
				Jump();
				isOnGround = false;
			}
            Move(hInput);*/
		if (Input.GetButtonDown("Jump") && isOnGround)
		{
			Jump();
			isOnGround = false;
		}

        if (prevHorizontal > 0)
        {
            direction = true;
        }
        else if (prevHorizontal < 0)
        {
            direction = false;
        }

        if (direction)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }

        cam.transform.position = transform.position;

        prevHorizontal = joystick.Horizontal;
    }

    void Move(float horizonalInput) {
        animator.SetFloat("Speed", Mathf.Abs(horizonalInput));
        
        Vector2 moveVel = rb.velocity;
        moveVel.x = horizonalInput * movementSpeed;
        rb.velocity = moveVel;

    }
    public void Jump()
    {
        if (isOnGround)
        {
            Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
            rb.velocity = movement;
            isOnGround = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isOnGround = true;
        }

        if (collision.gameObject.tag == "Water")
        {
           StartCoroutine(Death());
        }

        if (collision.gameObject.tag == "Finish") {
            StartCoroutine(Win());
        }
    }
    public void StartMoving(float horizonalInput)
    {
        hInput = horizonalInput;
    }

    IEnumerator Death()
    {
        Debug.Log("Died");
        animator.SetTrigger("Death");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MenuSzintSikertelen");
    }

    IEnumerator Win() {
        Debug.Log("Won");
        yield return new WaitForSeconds(1);
        int selectedLvl = globalStorage.Instance.selectedLevel;
        int difficulty = globalStorage.Instance.difficulty;
        globalStorage.Instance.SetStatus(selectedLvl - 1, new globalStorage.LevelStatus() {  isUnlocked=true, numberOfStars = (difficulty > globalStorage.Instance.levelStatuses[selectedLvl-1].numberOfStars ? difficulty: globalStorage.Instance.levelStatuses[selectedLvl - 1].numberOfStars) });
        if (selectedLvl != 4) {
            globalStorage.Instance.SetStatus(selectedLvl, new globalStorage.LevelStatus() { isUnlocked = true, numberOfStars = globalStorage.Instance.levelStatuses[selectedLvl].numberOfStars });
        }
        
        SceneManager.LoadScene("MenuSzintTeljesitve");
    }
}