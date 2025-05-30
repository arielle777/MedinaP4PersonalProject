using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
   private Rigidbody playerRb;
    private float xBound = 6;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        MovePlayer();
       
        if (transform.position.z < -xBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -xBound);
        }
        if (transform.position.z > xBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, xBound);
        }

    
    }
    void MovePlayer()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);

        
    }
}


