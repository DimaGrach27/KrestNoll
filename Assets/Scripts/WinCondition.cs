using UnityEngine;

public class WinCondition : MonoBehaviour
{
    private int countToWinNolik = 0;
    private int countToWinKrestik = 0;

    public static int whoIsWineble;

    public static bool isWin;

    public delegate void WinCond();
    WinCond _del;

    public event WinCond whoIsWin;

    private void Start()
    {
        isWin = false;
        whoIsWineble = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Circle")
            countToWinNolik++;

        if (collision.gameObject.tag == "Krestik")
            countToWinKrestik++;
    }

    private void Update()
    {
        if(countToWinKrestik == 3 || countToWinNolik == 3)
        {
            if (countToWinNolik == 3)
            {
                whoIsWineble = 1;
                isWin = true;
            }
            if (countToWinKrestik == 3)
            {
                whoIsWineble = 2;
                isWin = true;
            }
            Win();
        }     
    }

    public void Win()
    {
        if(whoIsWineble == 1)
            Debug.Log("Nolik Win!");
        else if(whoIsWineble == 2)
            Debug.Log("Krestik Win!");



        if (_del != null)
            _del();
    }
    public void RgisterHeandler(WinCond del)
    {
        _del = del;
    }
}
