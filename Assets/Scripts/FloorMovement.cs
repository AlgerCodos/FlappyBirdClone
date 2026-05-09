using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    public float speed = 6f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        if(transform.position.x <= -30.14f)
        {
            transform.position = new Vector3(1.028f, transform.position.y, transform.position.z);
        }
    }
}
