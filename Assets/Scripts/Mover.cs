using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;

    private const string Vertical = nameof(Vertical); 

    private void Update()
    {
        transform.Translate(_direction);
    }
}
