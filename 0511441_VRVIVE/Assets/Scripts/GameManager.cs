using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

public class GameManager : MonoBehaviour
{
    [Header("籃球數量")]
    public Text textBallCount;
    [Header("分數")]
    public Text textScore;
    [Header("二分音效")]
    public AudioClip soundTwo;
    [Header("三分音效")]
    public AudioClip soundThree;


    private AudioSource aud;
    private int ballCount = 5;
    public int score;

    private ThreePoint threePoint;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
        threePoint = FindObjectOfType<ThreePoint>();
    }

    public void UseBall(GameObject ball)
    {
        Destroy(ball.GetComponent<Throwable>());
        Destroy(ball.GetComponent<Interactable>());

        ballCount--;
        textBallCount.text = "籃球數量:" + ballCount + "/5";
    }

    private void OnTriggerEnter(Collider other)
    {


        if (threePoint.inThreePoint)
        {
            score += 3;
            aud.PlayOneShot(soundThree);
        }
        else
        {
            score += 2;
            aud.PlayOneShot(soundTwo);
        }
        textScore.text = "分數：" + score;
    }

    public void Replay()
    {
        SceneManager.LoadScene("投籃機");
    }

    public void Quit()
    {
        Application.Quit();
    }
}