using UnityEngine;

public class BottomPartyWall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Logic logic;
    
    void Start()
    {
        logic = GameObject.FindWithTag("Logic").GetComponent<Logic>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.GameOver();
            Debug.Log("Game Over");
        }
    }
}
