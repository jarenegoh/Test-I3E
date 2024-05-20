using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that enters the trigger has the "Player" tag
        if (other.gameObject.tag == "Player")
        {
            // Open the door
            OpenDoor();
        }
    }

    void OpenDoor()
    {
        // Store the object's rotation
        Vector3 newRotation = transform.eulerAngles;

        // Modify the new variable
        newRotation.y += 90f;

        //  Re-assign the value to the object's rotation
        transform.eulerAngles = newRotation;

        //opened = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position);
        Debug.Log(transform.eulerAngles);
        Debug.Log(transform.localScale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
