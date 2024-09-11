
using UnityEngine;

public class Ast_movment : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float sp;
    [SerializeField] private float ast_health;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        //kameran�n d���na ��kt���nda yok etmek i�in
        float downEdge = Camera.main.ScreenToViewportPoint(Vector3.zero).y - 9f;  
        rb.velocity = new Vector2(rb.velocity.x, sp * Time.deltaTime);

        if(ast_health<=0)
        {
            //Her astroit yok edildi�inde Astroits class�nda bulunan sayac� artt�rarak yok patlat�lanlar�n say�s�n� oyuncu g�rebilecek.
            Astroits.instance.sayac++;
            Destroy(gameObject);
        }
        if (transform.position.y < downEdge)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //astroitlerin b�y�kl���ne g�re canlar�
        if(collision.gameObject.tag=="F�ze")
        {
            ast_health -= 10;
        }

        //Kalkan ile temas etti�i zaman b�y�kl�k farketmeksizin direkt yok ediyor.
        if (collision.gameObject.tag == "Shield_player")
        {
            Destroy(gameObject);
        }
    }
}
