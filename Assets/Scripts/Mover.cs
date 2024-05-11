using UnityEngine;

public class SphereAnimation : MonoBehaviour
{
    [SerializeField] private Vector3 _currentPosition;

    private int _maxPosition;
    private int _minPosition;
    private bool _isNeedToReverse;


    // Start is called before the first frame update
    private void Start()
    {
        _maxPosition = 6;
        _minPosition = 2;
        _isNeedToReverse = false;
    }

    // Update is called once per frame
    private void Update()
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