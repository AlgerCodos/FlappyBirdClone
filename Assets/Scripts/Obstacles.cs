using System.Collections;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private float yPos;
    public GameObject obstacle;
    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            yPos = Random.Range(3f, 7f);
            Instantiate(obstacle, new Vector3(10f, yPos, 0), Quaternion.identity, transform);
        }

    }
}
