
using UnityEngine;

public class F�ze_circle : MonoBehaviour
{
    public GameObject f�zePrefab;
    public Transform firePoint;
    public int numF�ze = 8;
    public float fireR = 1f;
    public float sp = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireFuze();
        }
    }

    //Oyuncu space tu�una bastt��� zaman etraf�nda 360 derecede f�zeller ��kar ve hepsi ayr� y�nlere ilerler.
    private void FireFuze()
    {
        float ac�Aral�k = 360f / numF�ze;
        float ac� = 0f;

        for (int i = 0; i < numF�ze; i++)
        {
           
            Vector2 yon = Quaternion.Euler(0, 0, ac�) * Vector2.up * fireR;
            Vector3 f�zePosition = firePoint.position + (Vector3)yon;
            
            GameObject fz = Instantiate(f�zePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = fz.GetComponent<Rigidbody2D>();
            rb.velocity = yon * sp;
            ac� += ac�Aral�k;
        }
    }
}
