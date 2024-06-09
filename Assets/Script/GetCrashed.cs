using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetCrashed : MonoBehaviour
{
    [SerializeField] float waitTime = 2f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    [SerializeField] AudioClip slideSFX;

    bool hasCrashed = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();

            crashEffect.Play();

            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            // Debug.Log("You crashed!");
            Invoke("ReloadScene", waitTime);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}