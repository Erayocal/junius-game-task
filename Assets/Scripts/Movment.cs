
using UnityEngine;

public class Movment : MonoBehaviour
{
    [SerializeField] private float sp;
    private float hit_count = 0;

    void Update()
    {
        //Karakterin kontrolunu mouse'ýn hareketine göre takip etmesini saðlayarak daha rahat ve eylenceli oynanýþ saðladým.
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);        
        Vector2 konum = (Vector2)(mousePos - transform.position);
        konum.Normalize();

        transform.position = Vector2.MoveTowards(transform.position, mousePos, sp * Time.deltaTime);
        float yon = Mathf.Atan2(konum.y, konum.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, yon - 90));

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Astroit ile dört çarpýþmada oyuncuyu öldürme
        hit_count++;
        if (collision.gameObject.CompareTag("asteroid") && hit_count >= 4)
        {
            //Oyuncuyu Destroy etmek yerine aktifliðini kapatarak takip eden düþmanlarýn hata vermesini engelledim.
            gameObject.SetActive(false);
        }
    }
}
        
