using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Vector3 left;
    public Vector3 right;
    public GameObject gmScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gmScript.GetComponent<GMScript>().gameOver == false )
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
         {
            transform.position += left;
         }
        if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
         {
            transform.position += right;
         }
        }
        
    }
    
}
