using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Vector3 fall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= -5)
        //change -5 value to correct value
        {
            transform.position += fall;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
