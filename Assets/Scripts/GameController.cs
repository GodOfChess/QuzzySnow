using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private ThemeInfo themeInfo;
    private List<Theme> themes;
    private string theme, qDifficulty;

    private List<Question> easyList;
    private List<Question> mediumList;
    private List<Question> hardList;
    public List<Sprite> sprites;

    private Question randomQuestion;

    public Text textQuestion, textTheme, textScore, textLevel;
    public Button[] btnAnswers, btnThemes;
    public Text[] textThemes;
    public Text textHearts;

    private Button currentButton;
    private LockButtons locker;

    private int numberOfHearts = 3, score = 0, level = 1;
    public Animator themeAnimator, questionAnimator, santaAnimator;

    private int randIndex;

    private void Start()
    {
        themeInfo = FindObjectOfType<ThemeInfo>();
        themes = themeInfo.GetThemes();
        locker = FindObjectOfType<LockButtons>();
        StartGame();
    }

    private void Update()
    {
        textScore.text = $"Cчёт: {score}";
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void GenerateTheme()
    {
        textLevel.text = $"Уровень {level}";
        ShuffleList();
        for (int i = 0; i < 3; i++)
        {
            textThemes[i].text = themes[i].theme;
        }
    }

    private void ShuffleList()
    {
        themes = themes.OrderBy(x => Random.value).ToList();
    }

    public void SelectTheme(GameObject btnTheme)
    {
        theme = btnTheme.GetComponentInChildren<Text>().text;
        foreach (var item in themes.ToArray())
        {
            if (theme == item.theme)
            {
                themes.Remove(item);
            }
        }
        LockBtns(true, btnThemes);
        ChangeDisabledColor(btnTheme, Color.green);
        easyList = themeInfo.GetEasyList(theme);
        mediumList = themeInfo.GetMediumList(theme);
        hardList = themeInfo.GetHardList(theme);
        themeAnimator.SetTrigger("Close");
        textTheme.text = theme;
        locker.Lock();
    }

    public void GenerateQuestion(string difficulty)
    {
        LockBtns(false, btnAnswers);
        for (int i = 0; i < 3; i++)
        {
            ChangeDisabledColor(btnAnswers[i].gameObject, Color.white);
        }
        currentButton = LockButtons.currentButton;
        if (currentButton.GetComponent<ButtonInfo>().isDone == false)
        {
            qDifficulty = difficulty;
            if (difficulty == "easy")
            {
                GetQuestion(easyList);
            }
            else if (difficulty == "medium")
            {
                GetQuestion(mediumList);
            }
            else if (difficulty == "hard")
            {
                GetQuestion(hardList);
            }
            questionAnimator.SetTrigger("Open");
        }
        locker.Lock();
    }

    private void GetQuestion(List<Question> qList)
    {
        randIndex = Random.Range(0, qList.Count);
        randomQuestion = qList[randIndex];
        textQuestion.text = randomQuestion.question;
        List<string> answers = new List<string>(randomQuestion.answers);
        for (int i = 0; i < 3; i++)
        {
            int rand = Random.Range(0, answers.Count);
            btnAnswers[i].GetComponentInChildren<Text>().text = answers[rand];
            answers.RemoveAt(rand);
        }
    }

    public void OnClickAnswer(GameObject btnAnswer)
    {
        if (btnAnswer.GetComponentInChildren<Text>().text.ToString() == randomQuestion.answers[0])
        {
            LockBtns(true, btnAnswers);
            ChangeDisabledColor(btnAnswer, Color.green);
            currentButton.GetComponent<ButtonInfo>().ButtonDone();
            locker.Lock();
            if (qDifficulty == "easy")
            {
                score += 100;
                currentButton.GetComponent<Image>().sprite = sprites[0];
            }
            else if (qDifficulty == "medium")
            {
                score += 200;
                currentButton.GetComponent<Image>().sprite = sprites[1];
            }
            else if (qDifficulty == "hard")
            {
                score += 300;
                currentButton.GetComponent<Image>().sprite = sprites[2];
            }
        }
        else
        {
            LockBtns(true, btnAnswers);
            ChangeDisabledColor(btnAnswer, Color.red);
            LockButtons.currentButton = LockButtons.lastButton;
            LockButtons.currentLine = LockButtons.lastLine;
            LockButtons.currentFloor = LockButtons.lastFloor;
            locker.Lock();
            numberOfHearts -= 1;
            textHearts.text = numberOfHearts.ToString();
            if (numberOfHearts <= 0)
            {
                LoseGame();
            }
        }

        if (qDifficulty == "easy")
        {
            easyList.RemoveAt(randIndex);
        }
        else if (qDifficulty == "medium")
        {
            mediumList.RemoveAt(randIndex);
        }
        else if (qDifficulty == "hard")
        {
            hardList.RemoveAt(randIndex);
        }
        questionAnimator.SetTrigger("Close");
    }

    private void ChangeDisabledColor(GameObject btnAnswer, Color color)
    {
        var needcolor = btnAnswer.GetComponent<Button>().colors;
        needcolor.disabledColor = color;
        btnAnswer.GetComponent<Button>().colors = needcolor;
    }

    private void StartGame()
    {
        locker.LockAllButtons();
        GenerateTheme();
        textHearts.text = numberOfHearts.ToString();
        themeAnimator.SetTrigger("Open");
    }

    private void LoseGame()
    {
        santaAnimator.SetTrigger("Lose");
        locker.LockAllButtons();
        Invoke("ToMenu", 5f);
    }

    private void NextLvl()
    {
        level += 1;
        locker.GetStartButtons();
        locker.ReturnSprites();
        locker.UnDoneButtons();
        locker.LockAllButtons();
        LockBtns(false, btnThemes);
        for (int i = 0; i < 3; i++)
        {
            ChangeDisabledColor(btnThemes[i].gameObject, Color.white);
        }
    }

    public void GetCastle()
    {
        santaAnimator.SetTrigger("Win");
        if (themes.Count < 3)
        {
            Invoke("ToMenu", 10f);
        }
        else
        {
            NextLvl();
            Invoke("StartGame", 8f);
        }
    }

    private void LockBtns(bool flag, Button[] buttons)
    {
        foreach (var btn in buttons)
        {
            if (flag)
            {
                btn.interactable = false;
            }
            else
            {
                btn.interactable = true;
            }
        }
    }
}

public struct Question
{
    public string question;
    public string[] answers;
}