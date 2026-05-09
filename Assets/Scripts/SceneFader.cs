using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
public class SceneFader : MonoBehaviour
{
    public Image image;
    public float duration = 1f;
    public AudioSource music;
    void Start()
    {
        StartCoroutine(FadeOut());
    }
    public void SceneLoad(string sceneName)
    {
        image.gameObject.SetActive(true);
        StartCoroutine(FadeAndLoad(sceneName));
    }
    public IEnumerator FadeAndLoad(string sceneName)
    {
        float t = 0;
        Color c = image.color;
        while(t < duration)
        {
            t += Time.deltaTime;
            c.a = t/duration;
            if(music != null) music.volume = 1f - t/duration; 
            image.color = c;
            yield return null;
        }
        SceneManager.LoadScene(sceneName);
    }
    public IEnumerator FadeOut()
    {
        float t = 0;
        Color c = image.color;
        while(t < duration)
        {
            t += Time.deltaTime;
            c.a = 1f - t/duration;
            if(music != null) music.volume = t/duration;                            
            image.color = c;
            yield return null;
        }
        image.gameObject.SetActive(false);
    }
}
