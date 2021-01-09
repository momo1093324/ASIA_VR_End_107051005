using UnityEngine;
using UnityEngine.UI; //引用介面API

public class ScoreManager : MonoBehaviour
{
    ///得分為薑餅人
    [Header("介面分數")]
    public Text textScore;
    [Header("00")]
    public int score;
    [Header("投中的分數")]
    public int scoreIn = 1;
    [Header("投中音效")]
    public AudioClip soundIn;

    //音效來源aud
    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    //OTE條件
    private void OnTriggerEnter(Collider other)
    {
        //如果 碰撞物件標籤為薑餅人就加分
        //而且(&&) 薑餅人的高度>1.5  分數才不會出bug
        if (other.tag == "薑餅人" && other.transform.position.y > 1.5f) ;
        {
            AddScore();
        }
        //如果 碰撞物件名稱為Player，會顯示玩家進入
        if (other.transform.root.name == "Player")
        {
            //玩家進入二分區域，將投進分數改為二分
            print("玩家進入");
        }
    }
    //當碰撞物件離開碰撞範圍時執行一次
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name == "Player")
        {
            //將投進分數改為一分
            scoreIn = 1;
        }
    }
    //加分數
    private void AddScore()
    {
        score += scoreIn;       //分數遞增
        textScore.text = "00" + score;         
    }
}
