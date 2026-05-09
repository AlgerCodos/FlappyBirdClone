using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkinChoose : MonoBehaviour
{
    public GameObject birdOne;
    public GameObject birdTwo;
    public Animator bird1Anim;
    public Animator bird2Anim;
    
    void Start()
    {
        bird1Anim = birdOne.GetComponent<Animator>();
        bird2Anim = birdTwo.GetComponent<Animator>();
        if(PlayerPrefs.GetInt("Skin") == 0)
        {
            bird1Anim.SetTrigger("bird1choose");
        }
        if(PlayerPrefs.GetInt("Skin") == 1)
        {
            bird2Anim.SetTrigger("bird2choose");
        }
    }
    public void bird1()
    {
        if(PlayerPrefs.GetInt("Skin") == 1)
        {
            bird2Anim.SetTrigger("bird2closed");
        }
        PlayerPrefs.SetInt("Skin", 0);
        PlayerPrefs.Save();
        bird1Anim.SetTrigger("bird1choose");

    }
    public void bird2()
    {
        if(PlayerPrefs.GetInt("Skin") == 0)
        {
            bird1Anim.SetTrigger("bird1closed");
        }
        PlayerPrefs.SetInt("Skin", 1);
        PlayerPrefs.Save();
        bird2Anim.SetTrigger("bird2choose");
    }
    
}