using UnityEngine;

public class CheckDogs : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("TopBorder") || collision.gameObject.CompareTag("BottomBorder"))
        {
            Destroy(gameObject);
        }

        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
