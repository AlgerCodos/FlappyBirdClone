using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float speed = 4f;    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
        if(transform.position.x <= -14.79f)
        {
            transform.position = new Vector3(4.4f, 0, 0);
        }
    }
}
