using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        gameObject.tag = "Player";
        Debug.Log(gameObject.tag);
    }
}