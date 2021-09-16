using UnityEngine;
using UnityEngine.SceneManagement;


public class GamePlayMechanics : MonoBehaviour
{
    public void Back()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
