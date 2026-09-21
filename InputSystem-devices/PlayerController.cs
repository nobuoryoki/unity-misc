using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        if (Keyboard.current != null)
        {
            Debug.Log("Keyboard");
        }

        if (Mouse.current != null)
        {
            Debug.Log("Mouse");
        }

        Debug.Log("--");

        foreach (var device in InputSystem.devices)
        {
            Debug.Log(device.displayName);
        }
    }
}
