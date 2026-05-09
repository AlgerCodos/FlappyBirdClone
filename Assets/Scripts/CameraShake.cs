using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeAmount = 0.02f;
    private Vector3 initialPos;
    public PlayerController player;
    private float elapsedTime;
    public float shakeTime = 1f;
    void Awake()
    {
        initialPos = transform.position;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.isDead == true)
        {
            elapsedTime += Time.deltaTime * 10;
            if(elapsedTime < shakeTime)
            {
                transform.position = initialPos + Random.insideUnitSphere * shakeAmount;
            }
            Debug.Log(elapsedTime);
        }
        
    }
}
