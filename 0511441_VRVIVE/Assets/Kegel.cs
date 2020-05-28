using UnityEngine;

public class Kegel : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    int Count = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ball")
        {
            Invoke("DelayPointer", 2f);

        }
    }

    public void DelayPointer()
    {
        if (Count == 1)
        {
            return;
        }
        Count++;
        gameManager.score += 1;
        gameManager.textScore.text = "分數：" + gameManager.score;
        Debug.Log(gameManager.score);
    }
}
