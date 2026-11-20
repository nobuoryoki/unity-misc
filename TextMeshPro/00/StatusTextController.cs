using UnityEngine;
using TMPro;

public class StatusTextController : MonoBehaviour
{
    [SerializeField] PlayerController player;
    [SerializeField] TextMeshProUGUI statusText;

    void Update()
    {
        statusText.text = "a: " + player.a;
    }
}