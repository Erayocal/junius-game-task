
using UnityEngine;

public class Player_fire : MonoBehaviour
{

    public GameObject F�ze;
    public GameObject Fz;
    public Transform firePoint;
    [SerializeField] private float F�zeSp = 10f;

    //[SerializeField] private AudioSource f�zesesi;

    void Update()
    {
        //Ate� tu�unu mouse'a ta��yarak tek elle rahat oynan�labilecek hale getirdim.
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            /*e�er elimde ses olsayd� bu �ekilde eklerdim
              f�zesesi.Play();
             */
            fire();
        }

        //oyun ekran�ndan ��kt�ktan sonra yok etmesi i�in
        if (transform.position.y > 15f)
        {
            Destroy(gameObject);
        }

    }

    private void fire()
    {
        //F�ze yaratma ve hareketi
        GameObject Fz = Instantiate(F�ze, firePoint.position, firePoint.rotation);

        Rigidbody2D rb = Fz.GetComponent<Rigidbody2D>();

        rb.velocity = firePoint.up * F�zeSp;
    }
}
