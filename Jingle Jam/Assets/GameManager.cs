using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager: MonoBehaviour
{

    private static GameManager instance;
    public AudioClip santaLaugh;
    [SerializeField] AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public static GameManager GetInstance()
    {
        return instance;
    }

    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene("GameScene");
        audioSource.PlayOneShot(santaLaugh);

    }



}

