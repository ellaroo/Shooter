using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMScript : MonoBehaviour
{
    public bool gameOver;
    public int score;
    public int health;
    public float timer;

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                Instantiate(enemy, new Vector3(10f, Random.Range(-4.5f, 4f), 0f), Quaternion.identity);
                timer = 0;
            }
        }
    }

}
