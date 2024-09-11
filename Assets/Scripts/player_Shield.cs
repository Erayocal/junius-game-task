using System.Collections;
using UnityEngine;

public class player_Shield : MonoBehaviour
{
    public GameObject Shield;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "shield")
        {
            //kalkan 5 saniye a��k kald�ktan sonra kapanmas� i�in.
            StartCoroutine(Sh_stay_open(5f));
            Shield.SetActive(true);
            
        }
    }

    IEnumerator Sh_stay_open(float delay)
    {
        yield return new WaitForSeconds(delay);
        Shield.SetActive(false);
        
    }
}
