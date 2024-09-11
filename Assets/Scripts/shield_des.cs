
using UnityEngine;

public class shield_des : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Destroy(gameObject);
        }
    }
}
