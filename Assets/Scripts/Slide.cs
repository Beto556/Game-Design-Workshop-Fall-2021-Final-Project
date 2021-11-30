using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{

    public Rigidbody playerRb;
    public CapsuleCollider playerCollider;

    float originalHeight;
    public float slidingHeight;

    public float slideSpeed = 10f;

    bool isSliding;

    // Start is called before the first frame update
    void Start()
    {
        ///playerCollider = GetComponent<CapsuleCollider>();
        ///playerRb = GetComponent<Rigidbody>();
        originalHeight = playerCollider.height;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            Sliding();
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            GoUp();
        }
    }

    private void Sliding()
    {
        Debug.Log("Is Sliding!");
        playerCollider.height = slidingHeight;
        playerRb.AddForce(transform.forward * slideSpeed, ForceMode.VelocityChange);
    }

    private void GoUp()
    {
        playerCollider.height = originalHeight;
    }

}
