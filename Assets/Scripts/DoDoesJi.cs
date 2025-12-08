using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DoDoesJi : MonoBehaviour
{
    public RectTransform _canvasRect;
    public GameObject _joatPrefab;
    public GameObject _hitEffectPrefab;
    public GameObject _moveEffectPrefab;

    public int _joatCount = 2;
    public float _moveInterval = 1f;
    public float _hitEffectDuration = 1f;
    public float _moveEffectDuration = 0.5f;

    private void Start()
    {
        if (_canvasRect == null || _joatPrefab == null || _hitEffectPrefab == null)
            return;

        for (int i = 0; i < _joatCount; i++)
            SpawnJoat();
    }

    private void SpawnJoat()
    {
        GameObject joatObj = Instantiate(_joatPrefab, _canvasRect);

        RectTransform rt = joatObj.GetComponent<RectTransform>();
        Button btn = joatObj.GetComponent<Button>();

        if (rt == null || btn == null)
            return;

        rt.anchoredPosition = GetRandomPosition();
        btn.onClick.AddListener(() => OnJoatClicked(rt));
        StartCoroutine(JoatMoveLoop(rt));
    }

    private void OnJoatClicked(RectTransform rt)
    {
        SpawnHitEffect(rt);
        rt.anchoredPosition = GetRandomPosition();
    }

    private void SpawnHitEffect(RectTransform src)
    {
        if (_hitEffectPrefab == null)
            return;

        GameObject eff = Instantiate(_hitEffectPrefab, _canvasRect);

        RectTransform effRt = eff.GetComponent<RectTransform>();
        if (effRt != null)
            effRt.position = src.position;

        Destroy(eff, _hitEffectDuration);
    }

    private void SpawnMoveEffect(RectTransform src)
    {
        if (_moveEffectPrefab == null)
            return;

        GameObject eff = Instantiate(_moveEffectPrefab, _canvasRect);

        RectTransform effRt = eff.GetComponent<RectTransform>();
        if (effRt != null)
            effRt.position = src.position;

        Destroy(eff, _moveEffectDuration);
    }

    private IEnumerator JoatMoveLoop(RectTransform rt)
    {
        while (true)
        {
            yield return new WaitForSeconds(_moveInterval);
            SpawnMoveEffect(rt);
            rt.anchoredPosition = GetRandomPosition();
        }
    }

    private Vector2 GetRandomPosition()
    {
        float halfW = _canvasRect.rect.width * 0.5f;
        float halfH = _canvasRect.rect.height * 0.5f;
        return new Vector2(Random.Range(-halfW, halfW), Random.Range(-halfH, halfH));
    }
}
