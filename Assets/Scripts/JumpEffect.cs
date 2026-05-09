using System.Collections;
using UnityEngine;

public class JumpEffect : MonoBehaviour
{
    public GameObject[] sounds = new GameObject[4];
    void Start()
    {
        int randomNumber = Random.Range(0, 4);
        sounds[randomNumber].gameObject.SetActive(true); 
        StartCoroutine(DestroyJump());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DestroyJump()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
