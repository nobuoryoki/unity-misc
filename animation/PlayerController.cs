using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.speed = 1f;
    }

    void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            animator.speed = 1f;
            animator.Play("walk", 0, 0f);
        }

        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            animator.speed = 2f;
            animator.Play("walk", 0, 0f);
        }

        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            animator.speed = 1f;
            animator.Play("die", 0, 0f);
        }

        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            animator.speed = 0f;
        }
    }
}
