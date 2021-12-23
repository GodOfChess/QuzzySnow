using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockButtons : MonoBehaviour
{
    public List<Button> buttons;
    private GameController gameController;
    public static Button currentButton, lastButton;
    public static int currentLine, currentFloor, lastLine, lastFloor;
    private int tempLine, tempFloor;

    private void Start()
    {
        GetStartButtons();
        gameController = FindObjectOfType<GameController>();
    }

    public void GetCurrentButton(Button btn)
    {
        lastButton = currentButton;
        lastLine = lastButton.GetComponent<ButtonInfo>().GetCurrentLine();
        lastFloor = lastButton.GetComponent<ButtonInfo>().GetCurrentFloor();
        currentButton = btn;
        currentLine = currentButton.GetComponent<ButtonInfo>().GetCurrentLine();
        currentFloor = currentButton.GetComponent<ButtonInfo>().GetCurrentFloor();
    }

    public void Lock()
    {
        foreach (var btn in buttons)
        {
            tempLine = btn.GetComponent<ButtonInfo>().GetCurrentLine();
            tempFloor = btn.GetComponent<ButtonInfo>().GetCurrentFloor();
            btn.interactable = false;

            if (currentButton.GetComponent<ButtonInfo>().GetDone())
            {
                if (tempLine == currentLine || tempFloor == currentFloor)
                {
                    if (tempLine == currentLine - 1 && tempFloor == currentFloor)
                    {
                        btn.interactable = true;
                    }
                    if (tempLine == currentLine + 1 && tempFloor == currentFloor)
                    {
                        btn.interactable = true;
                    }

                    if (tempFloor == currentFloor - 1 && currentLine == tempLine)
                    {
                        btn.interactable = true;
                    }
                    if (tempFloor == currentFloor + 1 && currentLine == tempLine)
                    {
                        btn.interactable = true;
                    }
                }
            }
        }
    }

    public void ReturnSprites()
    {
        List<Sprite> sprites = gameController.sprites;
        foreach (var btn in buttons)
        {
            if (btn.tag == "easy")
            {
                btn.GetComponent<Image>().sprite = sprites[3];
            }
            else if (btn.tag == "medium")
            {
                btn.GetComponent<Image>().sprite = sprites[4];
            }
            else if (btn.tag == "hard")
            {
                btn.GetComponent<Image>().sprite = sprites[5];
            }
        }
    }

    public void GetStartButtons()
    {
        currentLine = 2;
        currentFloor = 1;
        currentButton = buttons[0];
        lastButton = buttons[0];
    }

    public void UnDoneButtons()
    {
        foreach (var btn in buttons)
        {
            if (btn.name != "Start")
            {
                btn.GetComponent<ButtonInfo>().isDone = false;
            }
        }
    }

    public void LockAllButtons()
    {
        foreach (var btn in buttons)
        {
            btn.interactable = false;
        }
    }
}
