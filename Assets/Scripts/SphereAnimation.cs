using UnityEngine;

public class SphereAnimation : MonoBehaviour
{
    private float _speed;
    private int _maxPosition;
    private int _minPosition;
    private bool _isNeedToReverse;
    [SerializeField] private Vector3 _currentPosition;

    // Start is called before the first frame update
    void Start()
    {
        _speed = 0.1f;
        _maxPosition = 6;
        _minPosition = 2;
        _isNeedToReverse = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(_isNeedToReverse)
        transform.Translate(-_currentPosition);
        else
            transform.Translate(_currentPosition);

        VerifyDirection();
    }

    private void VerifyDirection()
    { 
        if(transform.position.x >= _maxPosition)
            _isNeedToReverse = true;
        else if(transform.position.x <= _minPosition)
            _isNeedToReverse = false;
    }
}
