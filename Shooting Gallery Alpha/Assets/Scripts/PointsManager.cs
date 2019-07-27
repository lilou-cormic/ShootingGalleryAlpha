using System.Collections.Generic;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    private static PointsManager instance;

    [SerializeField]
    private UIPoints UIPointsPrefab = null;

    private Queue<UIPoints> UIPointsPool = new Queue<UIPoints>();

    private void Start()
    {
        instance = this;
    }

    public static void ShowPoints(int points, Vector3 position)
    {
        UIPoints uiPoints = instance.GetFromPool(position);
        uiPoints.SetPoints(points);
    }

    private UIPoints GetFromPool(Vector3 position)
    {
        UIPoints uiPoints;

        if (UIPointsPool.Count == 0)
        {
            uiPoints = Instantiate(instance.UIPointsPrefab, position, Quaternion.identity, transform);
            uiPoints.IsOut += () => { UIPointsPool.Enqueue(uiPoints); };
        }
        else
        {
            uiPoints = UIPointsPool.Dequeue();
            uiPoints.transform.position = position;
            uiPoints.gameObject.SetActive(true);
        }

        return uiPoints;
    }
}
