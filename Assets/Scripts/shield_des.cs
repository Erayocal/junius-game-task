
using UnityEngine;

public class shield_des : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //shield al�nda�ktan sonra yok edilmesi
        if(collision.gameObject.tag=="Player")
        {
            Destroy(gameObject);
        }
    }
}
