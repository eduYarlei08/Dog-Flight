using UnityEngine;

public class DogsMovement : MonoBehaviour
{
    [SerializeField] float dogSpeed;

    void Update()
    {
        transform.position += dogSpeed * Time.deltaTime * Vector3.left;        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);        
    }
}
