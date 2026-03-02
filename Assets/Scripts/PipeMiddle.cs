using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public Logic logic;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer==3)
            logic.addScore(1);
    }
}
