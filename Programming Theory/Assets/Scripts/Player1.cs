using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : Blueprint
{
    public Button run;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 15.0f;
        Force = 0.0f;
        run = GetComponent<Button>();
        run.onClick.AddListener(Move);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public override void Move()
    {
        
        
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(HorizontalInput, 0, VerticalInput) * Speed * Time.deltaTime);
        
    }
}
