using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class FallingCircles : MonoBehaviour
{
    [Header("떨어지는 속도 관련")]
    [SerializeField] private float _falling_Time = 3f;   
    [SerializeField] private float _falling_Speed = 0.5f;

    [Header("시간")]
    [SerializeField] private float _elapsed_Time = 0f;

    [Header("떨어질 대상")]
    public GameObject _obj;

    [SerializeField] private Player _player;

    void Start()
    {
        StartCoroutine(DropCircle());
    }

    private void Update()
    {
        _elapsed_Time += Time.deltaTime;   
    }

    IEnumerator DropCircle()
    {
        while (true)
        {
            float _randomX = Random.Range(-8.4f, 8.4f);

            Vector3 _spawnPos = new Vector3(
                _randomX,
                transform.position.y,
                transform.position.z
            );
            
            GameObject _circle = Instantiate(_obj, _spawnPos, Quaternion.identity);
            _player._target = _circle.transform;

            Rigidbody2D _rb = _circle.GetComponent<Rigidbody2D>();
            if (_rb != null)
            {
                _rb.gravityScale = _falling_Speed + _elapsed_Time/10;
            }

            if (_circle.transform.position.y <= -9) Destroy(_circle);

            yield return new WaitForSeconds(_falling_Time - _elapsed_Time/3);
        }
    }
}
