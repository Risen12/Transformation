using UnityEngine;

public class MultiMover : Scaler
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;

    private void Start()
    {
        _maxSize = 2;
        _minSize = 1;
        _isNeedToGrow = false;
    }

    private void Update()
    {
        if (_isNeedToGrow)
            Decrease();
        else
            Grow();

        transform.Rotate(transform.up * _rotateSpeed * Time.deltaTime);

        transform.Translate(transform.forward * _moveSpeed * Time.deltaTime);

        VerifyScale();
    }
}
