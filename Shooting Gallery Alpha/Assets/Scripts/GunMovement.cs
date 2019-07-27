using UnityEngine;

public class GunMovement : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer = null;

    private Camera Camera = null;

    public float offset = 1.5f;

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
        bool flip = mousePos.x < 0;

        SpriteRenderer.flipX = flip;

        transform.position = new Vector3(Mathf.Clamp(mousePos.x + (flip ? -offset : offset), -8.5f, 8.5f), transform.position.y);
    }

    private void OnDestroy()
    {
        TimeKeeper.TimeIsUp -= TimeKeeper_TimeIsUp;
    }

    private void TimeKeeper_TimeIsUp()
    {
        enabled = false;
    }
}
