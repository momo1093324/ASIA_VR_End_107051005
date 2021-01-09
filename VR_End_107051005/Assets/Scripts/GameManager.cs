using UnityEngine;
using UnityEngine.SceneManagement;//引用場景管理器API

public class GameManager : MonoBehaviour
{
    // <summary>
    /// 重新遊戲
    /// </summary>
    public void RestartGame()
    {
        SceneManager.LoadScene("VR_End_107051005");
    }
    /// <summary>
    ///關閉遊戲 
    /// </summary>
    public void QuitGame()
    {
        //離開遊戲
        Application.Quit();
    }
}
