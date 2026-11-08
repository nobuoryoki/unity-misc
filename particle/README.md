# Particle System

"Particle System" を "Add Component" から追加しているときは以下のような書き方もできる．

```
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        GetComponent<ParticleSystem>().Play();
    }
}
```