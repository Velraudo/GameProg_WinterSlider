using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float waitTime = 2f;
    [SerializeField] ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            // Debug.Log("You finished!");
            Invoke("ReloadScene", waitTime);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
