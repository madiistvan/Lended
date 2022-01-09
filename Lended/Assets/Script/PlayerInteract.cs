using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private bool pressed = false;
    private bool interactable = false;
    public GameObject currentinteract = null;
    public GameObject target1;
    public Animator animator;
	public GameObject button;
	private bool done=false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentinteract = collision.gameObject;
        if (collision.CompareTag("interactable") && !pressed)
        {
            globalStorage.Instance.isInterractingWithChest = true;
            Debug.Log("interactable");
			button.SetActive(true);
            interactable = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        currentinteract = null;
        if (collision.CompareTag("interactable"))
        {
            Debug.Log("not interactable");
            interactable = false;
        }
    }
    private void Update()
    {
        if (interactable && pressed&&!done)
        {
            target1.SetActive(true);
			done=true;

        }
        if (currentinteract==null) { done = false; }
        else if (!interactable && !pressed && currentinteract != null)
        {
           // button.SetActive(false);
        }
    }
    public void Pressed() {
        Debug.Log("press");

        pressed = !pressed;
		
    }
}
