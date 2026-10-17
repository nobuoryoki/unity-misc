using UnityEngine;

public class ItemController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(this.gameObject.tag))
        {
            Destroy(this.gameObject);
        }
    }
}
