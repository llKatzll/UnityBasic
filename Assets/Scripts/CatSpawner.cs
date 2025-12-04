using Unity.VisualScripting;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{
    [SerializeField] private Sprite _joat_cat;
    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private Vector2 _startPos = new Vector2(-6f, 0f);

    void Start()
    {
        Color[] _colors =
        {
            Color.red,
            new Color(1f,0.5f,0), //ÁÖÈ² ³»³ö¶ó
            Color.yellow,
            Color.green,
            Color.blue,
            Color.purple,
        };

        for(int i = 0; i < 7; i++)
        {
            GameObject _obj = new GameObject();

            SpriteRenderer _sr = _obj.AddComponent<SpriteRenderer>();

            _sr.sprite = _joat_cat;

            _obj.transform.position = new Vector3(_startPos.x + i * 2f, _startPos.y, 0);

            switch (i)
            {
                case 0:
                    _obj.name = "APPLE joatCat";
                    break;
                case 1:
                    _obj.name = "ORANGE joatCat";
                    break;
                case 2:
                    _obj.name = "LEMON joatCat";
                    break;
                case 3:
                    _obj.name = "AVOCADO joatCat";
                    break;
                case 4:
                    _obj.name = "AVATAR joatCat";
                    break;
                case 5:
                    _obj.name = "MURASAKI joatCat";
                    break;
                case 6:
                    _obj.name = "ORIGINAL joatCat";
                    break;
            }

            _sr.color = _colors[i];
        }
        
    }

    void Update()
    {
        
    }
}
