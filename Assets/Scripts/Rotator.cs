using UnityEngine;

public class CubeAnimation : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(transform.up * _speed * Time.deltaTime);
    }
}
