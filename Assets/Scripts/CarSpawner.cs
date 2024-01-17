using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefabCar;

    private void Awake()
    {
        Instantiate(_prefabCar);
    }
}