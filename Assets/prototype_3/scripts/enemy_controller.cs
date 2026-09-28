using UnityEngine;

public class enemy_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Vector2 velocity;
    public Rigidbody2D RB;
    public float speed;
    public float force;
    public GameObject player;
    public float timer;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (player.transform.position - transform.position).normalized;
        Vector2 lookDir = new Vector2 (direction.x, 0);
        timer -= Time.deltaTime;
        velocity = direction * speed;
        if (timer <= 0)
        {
            RB.linearVelocity = velocity;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //RB.linearVelocity = Vector2.zero;
            RB.linearVelocity = -velocity * force;
            timer = 2;
            //Debug.Log("hit");
        }
        else if (collision.gameObject.tag == "Hazard")
        {
            spawner_controller.score += 1;
            spawner_controller.enemies += 1;
            //Debug.Log(spawner_controller.enemies);
            Destroy(gameObject);
        }
    }
    
}
