
using UnityEngine;

public class Füze_circle : MonoBehaviour
{
    public GameObject füzePrefab;
    public Transform firePoint;
    public int numFüze = 8;
    public float fireR = 1f;
    public float sp = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireFuze();
        }
    }

    //Oyuncu space tuþuna bastýðý zaman 360 derece etrafýnda füzeler oluþur.
    private void FireFuze()
    {
        float acýAralýk = 360f / numFüze;
        float acý = 0f;

        for (int i = 0; i < numFüze; i++)
        {
            
            Vector2 yon = Quaternion.Euler(0, 0, acý) * Vector2.up * fireR;
            
            GameObject fz = Instantiate(füzePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = fz.GetComponent<Rigidbody2D>();
            rb.velocity = yon * sp;
            acý += acýAralýk;
        }
    }
}
