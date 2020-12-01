using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour
{
    public Text text;
	void Start()
    {
        text.enabled = false;

    }



    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Door")
        {
            text.enabled = true;
            Animator anim = other.GetComponentInChildren<Animator>();
            if(Input.GetKeyDown(KeyCode.E))
                anim.SetTrigger("OpenClose");
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door")
        {
            text.enabled = false;
        }
    }
}
