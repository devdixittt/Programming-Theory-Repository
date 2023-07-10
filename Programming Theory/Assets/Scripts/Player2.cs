using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : Blueprint
{
    public Button runjump;
    public Rigidbody playerrb;
    private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        Force = 15.0f;
        Speed = 5.0f;
        playerrb = GetComponent<Rigidbody>();
        runjump = GetComponent<Button>();
        runjump.onClick.AddListener(Move);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public override void Move()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
         {
             playerrb.AddForce(Force * Vector3.up, ForceMode.Impulse);
            isGrounded = false;
         }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
