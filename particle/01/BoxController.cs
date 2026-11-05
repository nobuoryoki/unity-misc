using UnityEngine;

public class BoxController : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] particles;

    void OnCollisionEnter(Collision other)
    {
        int index = 0;

        if (other.gameObject.CompareTag("Enemy"))
        {
            index = 0;
        }
        else if (other.gameObject.CompareTag("Item"))
        {
            index = 1;
        }
        else
        {
            index = 2;
        }

        particles[index].Stop();
        particles[index].Play();
    }
}