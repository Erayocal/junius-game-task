using System.Collections;
using UnityEngine;

public class player_Shield : MonoBehaviour
{
    public GameObject Shield;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "shield")
        {
            //kalkan 5 saniye açýk kaldýktan sonra kapanmasý için.
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
