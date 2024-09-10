
using UnityEngine;

public class Movment : MonoBehaviour
{
    [SerializeField] private float sp;
    private float hit_count = 0;


    
    void Update()
    {
        //Player hareketi
        float move_x = Input.GetAxis("Horizontal");
        float move_y = Input.GetAxis("Vertical");


        Vector3 v1 = new Vector3(move_x, move_y, 0);
        transform.position += sp * Time.deltaTime * v1;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Astroit ile üç çarpýþmada oyuncuyu öldürme
        hit_count++;
        if (collision.gameObject.CompareTag("asteroid") && hit_count >= 3)
        {
            Destroy(gameObject);
        }
    }
}
        
