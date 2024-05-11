using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    protected int _maxSize;
    protected int _minSize;
    protected bool _isNeedToGrow;

    private void Start()
    {
        _maxSize = 2;
        _minSize = 1;
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

    protected void Grow()
    {
        Vector3 scale = new Vector3(_speed * Time.deltaTime, _speed * Time.deltaTime, _speed * Time.deltaTime);
        transform.localScale += scale;
    }

    protected void Decrease()
    {
        Vector3 scale = new Vector3(_speed * Time.deltaTime, _speed * Time.deltaTime, _speed * Time.deltaTime);
        transform.localScale -= scale;
    }

    protected void VerifyScale()
    {
        if (transform.localScale.x <= _minSize && transform.localScale.y <= _minSize && transform.localScale.z <= _minSize)
            _isNeedToGrow = true;
        else if(transform.localScale.x > _maxSize && transform.localScale.y > _maxSize && transform.localScale.z > _maxSize)
            _isNeedToGrow = false;

    }
}
