using UnityEngine;

public class BoxController : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;

    void OnCollisionEnter(Collision other)
    {
        particle.Stop();
        particle.Play();
    }
}