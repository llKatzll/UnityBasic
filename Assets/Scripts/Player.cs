using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private GameObject _effectPrefab;

    public Transform _target;

    void Update()
    {
        PlayerMove();
        Death();
    }

    void Death()
    {
        if (_target == null)
            return;

        Vector3 _diff = _target.position - transform.position;

        float _distance = _diff.magnitude;

        if (_distance <= 0.5f)
        {
            Instantiate(_effectPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    void PlayerMove()
    {
        float move = _speed * Time.deltaTime;
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.A))
            pos.x -= move;

        if (Input.GetKey(KeyCode.D))
            pos.x += move;

        pos.x = Mathf.Clamp(pos.x, -8.4f, 8.4f);
        transform.position = pos;
    }
}
