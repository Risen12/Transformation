using UnityEngine;
public class CapsuleAnimation : MonoBehaviour
{
    [SerializeField] private float _speed;

    private int _maxSize;
    private int _startSize;
    private bool _isNeedToGrow;

    private void Start()
    {
        _maxSize = 2;
        _startSize = 1;
        _isNeedToGrow = true;
    }

    private void Update()
    {
        if (_isNeedToGrow)
            Grow();
        else
            Decrease();

        VerifyScale();
    }

    private void Grow()
    {
        Vector3 scale = new Vector3(_speed * Time.deltaTime, _speed * Time.deltaTime, _speed * Time.deltaTime);
        transform.localScale += scale;
    }

    private void Decrease()
    {
        Vector3 scale = new Vector3(_speed * Time.deltaTime, _speed * Time.deltaTime, _speed * Time.deltaTime);
        transform.localScale -= scale;
    }

    private void VerifyScale()
    {
        if (transform.localScale.x <= _startSize && transform.localScale.y <= _startSize && transform.localScale.z <= _startSize)
            _isNeedToGrow = true;
        else if(transform.localScale.x > _maxSize && transform.localScale.y > _maxSize && transform.localScale.z > _maxSize)
            _isNeedToGrow = false;

    }
}
