using UnityEngine;

public class SecondCubeAnimation : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    private int _maxSize;
    private int _minSize;
    private Vector3 _direction;
    private bool _isNeedToDecrease;


    // Start is called before the first frame update
    private void Start()
    {
        _maxSize = 2;
        _minSize = 1;
        _isNeedToDecrease = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (_isNeedToDecrease)
            Decrease();
        else
            Grow();

        transform.Rotate(transform.up * _rotateSpeed * Time.deltaTime);

        transform.Translate(transform.forward * _moveSpeed * Time.deltaTime);

        VerifyScale();
    }

    private void Grow()
    {
        Vector3 scale = new Vector3(_moveSpeed * Time.deltaTime, _moveSpeed * Time.deltaTime, _moveSpeed * Time.deltaTime);
        transform.localScale += scale;
    }

    private void Decrease()
    {
        Vector3 scale = new Vector3(_moveSpeed * Time.deltaTime, _moveSpeed * Time.deltaTime, _moveSpeed * Time.deltaTime);
        transform.localScale -= scale;
    }

    private void VerifyScale()
    {
        if (transform.localScale.x <= _minSize && transform.localScale.y <= _minSize && transform.localScale.z <= _minSize)
            _isNeedToDecrease = false;
        else if(transform.localScale.x >= _maxSize && transform.localScale.y >= _maxSize && transform.localScale.z >= _maxSize)
            _isNeedToDecrease = true;
    }
}
