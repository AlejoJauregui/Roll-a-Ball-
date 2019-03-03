using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectObjects : MonoBehaviour
{
    public AudioClip soundCoins;
    AudioSource audioCoinsSource;
    public Transform particles;
    ParticleSystem systemParticles;
    Vector3 position;
    int points = 0;

    public void OnTriggerEnter (Collider objCollision)
    {
        if(objCollision.gameObject.CompareTag("Coins"))
        {
            objCollision.gameObject.SetActive(false);
            ActivateParticles(objCollision);
            playSound(soundCoins);
            points++;
        }
        if(points == 15)
        {
            Debug.Log("You Win!!");
            SceneManager.LoadScene(2);
        }

    }
    void Start()
    {
        StopParticles();
    }
    void StopParticles()
    {
        systemParticles = particles.GetComponent<ParticleSystem>();
        systemParticles.Stop();
    }
    void ActivateParticles(Collider objCollision)
    {
        position = objCollision.gameObject.transform.position;
        particles.position = position;
        systemParticles = particles.GetComponent<ParticleSystem>();
        systemParticles.Play(); 
    }
    
    void playSound(AudioClip sound)
    {
        audioCoinsSource = GetComponent<AudioSource>();
        audioCoinsSource.Play();
    }
}
