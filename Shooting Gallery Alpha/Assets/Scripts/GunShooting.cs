using UnityEngine;

public class GunShooting : MonoBehaviour
{
    [SerializeField]
    private AudioClip NoHitSound = null;

    private void Awake()
    {
        TimeKeeper.TimeIsUp += TimeKeeper_TimeIsUp;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D col = Physics2D.OverlapCircle(mousePos, 0.01f);

            if (col != null && col.CompareTag("Target"))
            {
                Target target = col.GetComponentInParent<Target>();
                target.Hit(mousePos);
            }
            else
            {
                SoundPlayer.Play(NoHitSound);
            }
        }
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
