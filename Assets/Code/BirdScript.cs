using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public Rigidbody2D myRigidBody;
    public float flapStrength; 
    public Logic logic;
    void Start()
    {
        logic = GameObject.FindWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
    }
}
