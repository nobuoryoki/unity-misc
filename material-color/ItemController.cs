using UnityEngine;

public class ItemController : MonoBehaviour
{
    Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = new Color(0.0f, 0.0f, 1.0f);
    } 
}
