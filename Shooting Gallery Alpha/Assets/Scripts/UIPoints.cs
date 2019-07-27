using System;
using UnityEngine;

public class UIPoints : MonoBehaviour
{
    [SerializeField]
    private UINumber TensNumber = null;
    [SerializeField]
    private UINumber UnitsNumber = null;

    private float _timeLeft = 0f;

    public event Action IsOut;

    private void OnEnable()
    {
        _timeLeft = 1.5f;
    }

    public void SetPoints(int points)
    {
        int tens = points / 10;
        points -= tens * 10;

        if (tens > 0)
            TensNumber.SetNumber(tens);

        TensNumber.gameObject.SetActive(tens > 0);

        UnitsNumber.SetNumber(points);
    }

    private void Update()
    {
        _timeLeft -= Time.deltaTime;

        if (_timeLeft <= 0)
        {
            gameObject.SetActive(false);
            IsOut?.Invoke();
            return;
        }

        transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.up * 0.2f, Time.deltaTime * 1.5f);
    }
}
