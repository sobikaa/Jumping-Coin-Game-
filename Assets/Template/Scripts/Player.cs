using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{

    [SerializeField] float Speed = 6f;
    [SerializeField] float jump = 5f;
    [SerializeField] private AudioSource backgroundMusic;

    void Start()
    {
   #     backgroundMusic.Play();

    }
    void Update() 
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput * Speed, GetComponent<Rigidbody>().velocity.y, verticalInput * Speed);

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, jump, GetComponent<Rigidbody>().velocity.z);
            
        }

    }

}
    