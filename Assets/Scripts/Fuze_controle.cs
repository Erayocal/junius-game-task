

using UnityEngine;

public class Fuze_controle : MonoBehaviour
{
    
    private float speed;

    public void Initialize(float speed)
    {
        this.speed = speed;
    }

    private void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;

        // E�er f�ze oyun alan�ndan ��kt�ysa, havuza geri koy
        if (transform.position.y > 15f || transform.position.y < -15f ||
            transform.position.x > 10f || transform.position.x < -10f)
        {
            GameObject.FindObjectOfType<Player_fire>().ReturnMissileToPool(this);
        }
    }
}
