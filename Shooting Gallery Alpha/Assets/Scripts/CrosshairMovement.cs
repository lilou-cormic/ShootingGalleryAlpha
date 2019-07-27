using UnityEngine;

public class CrosshairMovement : MonoBehaviour
{
    private Camera Camera = null;

    private void Awake()
    {
        TimeKeeper.TimeIsUp += TimeKeeper_TimeIsUp;
    }

    private void Start()
    {
        Camera = Camera.main;
    }

    private void LateUpdate()
    {
        Vector2 mousePos = Camera.ScreenToWorldPoint(Input.mousePosition);

        Cursor.visible = mousePos.x < -8.5f || mousePos.x > 8.5f || mousePos.y < -3.5f || mousePos.y > 4.5f;

        transform.position = new Vector3(Mathf.Clamp(mousePos.x, -8.5f, 8.5f), Mathf.Clamp(mousePos.y, -3.5f, 4.5f));
    }

    private void OnDestroy()
    {
        TimeKeeper.TimeIsUp -= TimeKeeper_TimeIsUp;
    }

    private void TimeKeeper_TimeIsUp()
    {
        Cursor.visible = true;
        enabled = false;
    }
}
