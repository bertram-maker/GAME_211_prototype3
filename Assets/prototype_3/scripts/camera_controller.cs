using UnityEngine;

public class camera_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;
    public Vector2 position;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = player.transform.position;
        transform.position = new Vector3(position.x,position.y,transform.position.z);
    }
}
