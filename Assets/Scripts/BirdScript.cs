using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRB;
    public float flapStrength;
    public Logic logic;
    public bool isAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            myRB.linearVelocity = Vector2.up * flapStrength * myRB.gravityScale;
        }
        if (transform.position.y < -15 || transform.position.y > 15)
        {
            logic.gameOver();
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isAlive = false;
    }


}
