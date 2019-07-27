using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOverPanel = null;

    [SerializeField]
    private AudioSource GameOverAudioSource = null;

    private void Awake()
    {
        GameOverPanel.SetActive(false);

        TimeKeeper.TimeIsUp += TimeKeeper_TimeIsUp;
    }

    private void OnDestroy()
    {
        TimeKeeper.TimeIsUp -= TimeKeeper_TimeIsUp;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        MainMenu.Quit();
    }

    private void TimeKeeper_TimeIsUp()
    {
        GameOverPanel.SetActive(true);
        GameOverAudioSource.Play();
    }
}
