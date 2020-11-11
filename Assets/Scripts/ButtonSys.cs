using UnityEngine;

public class ButtonSys : MonoBehaviour
{
    [SerializeField] GameObject nolik;
    [SerializeField] GameObject kresik;

    private bool isLock = false;

    public void ClickButton()
    {
        if (!isLock && !WinCondition.isWin)
        {
            if (NewBehaviourScript.firstPlayer)
            {
                nolik.SetActive(true);
                NewBehaviourScript.firstPlayer = false;
            }
            else
            {
                kresik.SetActive(true);
                NewBehaviourScript.firstPlayer = true;
            }
        }

        isLock = true;
    }
}
