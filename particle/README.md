# Particle System

"Particle System" を "Add Component" から追加しているときは以下のような書き方もできる．

```
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
        particle.Play();
    }
}
```