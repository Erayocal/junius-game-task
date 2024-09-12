
using UnityEngine;

public class Füze_des : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Füzenin çarpışma anında yok olması için
        if (collision.gameObject.CompareTag("asteroid"))
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        //oyun ekranından çıktığı zaman füzeyi yok etmesi için
        if (transform.position.y > 15f || transform.position.y < -7f || transform.position.x > 15 || transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}
