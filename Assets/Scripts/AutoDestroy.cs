using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField] private float _minY = -15f; 
    void Update()
    {
        if (transform.position.y < _minY)
        {
            Destroy(gameObject);
        }
    }
}
