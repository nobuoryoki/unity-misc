using UnityEngine;

public class BoxController : MonoBehaviour
{
    private ParticleSystem particle;

    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    void OnCollisionEnter(Collision other)
    {
        particle.Stop();
        particle.Play();
    }
}