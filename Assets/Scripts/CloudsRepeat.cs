using UnityEngine;

public class CloudsRepeat : MonoBehaviour
{
    [SerializeField] private float cloudsSpeed;
    [SerializeField] private Renderer render;

    // Update is called once per frame
    void Update()
    {
        render.material.mainTextureOffset += new Vector2(cloudsSpeed * Time.deltaTime, 0);
    }
}
