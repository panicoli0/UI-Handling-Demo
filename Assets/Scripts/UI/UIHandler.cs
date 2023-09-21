using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private Button _mainMenuButton;
    [SerializeField] private Button _creditsButton;
    [SerializeField] private Button _quitButton;

    [SerializeField] private GameObject _mainMenuPanel;

    public void MainMenuButton()
    {
        _mainMenuPanel.gameObject.SetActive(true);
    }
}
