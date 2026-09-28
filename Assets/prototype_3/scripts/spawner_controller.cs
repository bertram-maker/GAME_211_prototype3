using TMPro;

using UnityEngine;

public class spawner_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static int score;
    public static int enemies;
    public GameObject enemy;
    public int spawns;
    public bool wait;
    public TextMeshProUGUI display;
    void Start()
    {
        wait = false;
        score = 0;
        enemies = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemies <= spawns && wait == false)
        {
            for (int i = spawns; i > 0; i--)
            {
                Instantiate(enemy);
                wait = true;
            }
        }
        
        if (enemies == spawns)
        {
            spawns += 5;
            enemies = 0;
            wait = false;
        }

        if (score == 100)
        {
            Destroy(gameObject);
        }
        display.text = "Score: " + score;
    }
}
