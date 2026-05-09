using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 6f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        if(transform.position.x <= -22)
        {
            Destroy(gameObject);
        }
    }
}
