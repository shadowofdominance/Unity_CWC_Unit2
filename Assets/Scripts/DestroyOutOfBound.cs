using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float topBound = 35;
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -topBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}